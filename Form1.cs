using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Browser.Models;
namespace Browser
{
    public partial class Form1 : Form
    {
        string _connectionString;
        SqlConnection _connection;
        SqlDataAdapter _adapter;
        SqlCommandBuilder _builder;
        DataSet _dataSet;
        public Form1()
        {
            InitializeComponent();
            try
            {
                _connectionString =
                    ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
                _connection = new SqlConnection(_connectionString);
                string initQuery = "select * from Categories order by Id;" +
                                   "select * from Sites order by Id;";
                _adapter = new SqlDataAdapter(initQuery,_connection);
                _builder = new SqlCommandBuilder(_adapter);
                _dataSet = new DataSet();
                _adapter.Fill(_dataSet);
                LoadCategories();
            }
            catch(Exception err)
            {
                MessageBox.Show($"Initializing error\n{err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void LoadCategories()
        {
            try
            {
                categories_list.Items.Clear();
                foreach(DataRow row in _dataSet.Tables[0].Rows)
                {
                    Category temp = new Category() { 
                        Id = (int)row["Id"],
                        Name = row["Name"].ToString() };
                    categories_list.Items.Add(temp);
                }
                categories_list.DisplayMember = "Name";
                if (categories_list.Items.Count > 0)
                    categories_list.SelectedIndex = 0;
            }
            catch (Exception err)
            {
                MessageBox.Show($"Categories loading error\n {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadSites()
        {

            int CategoryId=-1;
            if (categories_list.SelectedIndex != -1 && categories_list.Items.Count > 0)
                CategoryId = (categories_list.SelectedItem as Category).Id;
            else
                return;
            try
            {
                sites_list.Items.Clear();
                DataRow[] selectedSites =
                    _dataSet.Tables[1].Select($"CategoryId = {CategoryId}");
                foreach (DataRow row in selectedSites)
                {
                    Site site = new Site()
                    {
                        Id = (int)row["Id"],
                        Name = row["Name"].ToString(),
                        Addr = row["Addr"].ToString()
                    };
                    sites_list.Items.Add(site);
                }
                sites_list.DisplayMember = "Name";
                
            } 
            catch (Exception err)
            {
                MessageBox.Show($"Failed to load sites\n{err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            url_textBox.Text = webBrowser1.Url.ToString();
            if (webBrowser1.CanGoBack)
                back_button.Enabled = true;
            else
                back_button.Enabled = false;

            if (webBrowser1.CanGoForward)
                front_button.Enabled = true;
            else
                front_button.Enabled = false;
        }

        private void url_textBox_Click(object sender, EventArgs e)
        {
            url_textBox.SelectAll();
        }

        private void go_button_Click(object sender, EventArgs e)
        {
            goToSite();
        }
        private void url_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                goToSite();
        }
        private void goToSite(string addr)
        {
            url_textBox.Text = addr;
            goToSite();
        }
        private void goToSite()
        {
            string address = url_textBox.Text;
            if (String.IsNullOrWhiteSpace(address))
                {
                    MessageBox.Show("Wrong address!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(address.Contains('.') == false)
                {
                    address = $"https://www.bing.com/search?q={address}";
                }
                webBrowser1.Navigate(address);
            }
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.bing.com");
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
                webBrowser1.GoBack();
        }

        private void front_button_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
        }

        private void sites_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sites_list.SelectedIndex > -1)
            {
                goToSite((sites_list.SelectedItem as Site).Addr);
            }
        }

        private void categories_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categories_list.SelectedIndex > -1)
            {
                LoadSites();  
            }
        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoriesEditor editor = new CategoriesEditor();
            editor.ActionName = "Add category";
            if (editor.ShowDialog() == DialogResult.OK)
            {
                string categoryName = editor.CategoryName;
                int count = _dataSet.Tables[0].Rows.Count;
                int lastId = (int)_dataSet.Tables[0].Rows[count - 1]["id"];
                DataRow newRow = _dataSet.Tables[0].NewRow();
                newRow["Id"] = lastId + 1;
                newRow["Name"] = categoryName;
                _dataSet.Tables[0].Rows.Add(newRow);
                _dataSet.AcceptChanges();
                _adapter.Update(_dataSet.Tables[0]);
                LoadCategories();
                MessageBox.Show("Category successfully added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void deleteCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoriesEditor editor = new CategoriesEditor();
            editor.ActionName = "Delete category";
            if (categories_list.SelectedIndex > -1)
                editor.CategoryName = (categories_list.SelectedItem as Category).Name;
            if (editor.ShowDialog() == DialogResult.OK)
            {
                string categoryName = editor.CategoryName;
                bool tg = false;
                foreach(DataRow row in _dataSet.Tables[0].Rows)
                {
                   if (row["Name"].ToString() == categoryName)
                    {
                        row.Delete();
                        tg = true;
                    }
                }
                if (tg == true)
                {
                _dataSet.AcceptChanges();
                _adapter.Update(_dataSet.Tables[0]);
                LoadCategories();
                MessageBox.Show("Category deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Category isn`t exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
        }

        private void editCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoriesEditor editor = new CategoriesEditor();
            editor.ActionName = "Edit category";
            if (categories_list.SelectedIndex > -1)
                editor.CategoryName = (categories_list.SelectedItem as Category).Name;
            if (editor.ShowDialog() == DialogResult.OK)
            {
                string categoryName = editor.CategoryName;
                if(categoryName != (categories_list.SelectedItem as Category).Name)
                {
                    int selectedId = (categories_list.SelectedItem as Category).Id;
                    DataRow editedRow = _dataSet.Tables[0].Select($"Id = {selectedId}")[0];
                    editedRow["Name"] = categoryName;
                    _dataSet.AcceptChanges();
                    _adapter.Update(_dataSet.Tables[0]);
                    LoadCategories();
                    MessageBox.Show("Category updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void addSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SitesEditor editor = new SitesEditor();
            editor.ActionName = "Add site";
            foreach(Category category in categories_list.Items)
            {
                editor.Categories.Add(category);
            }
            if(editor.ShowDialog() == DialogResult.OK)
            {
                string siteName = editor.SiteName;
                string address = editor.AddressName;
                int categoryId = editor.SelectedCategoryId;
                int count = _dataSet.Tables[1].Rows.Count;
                int lastId = (int)_dataSet.Tables[1].Rows[count - 1]["Id"];
                DataRow newRow = _dataSet.Tables[1].NewRow();
                newRow["Id"] = lastId + 1;
                newRow["Name"] = siteName;
                newRow["Addr"] = address;
                newRow["CategoryId"] = categoryId;

                _dataSet.Tables[1].Rows.Add(newRow);
                _dataSet.AcceptChanges();
                _adapter.Update(_dataSet.Tables[1]);
                LoadSites();
                MessageBox.Show("Site successfully added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void deleteSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSiteForm deleter = new DeleteSiteForm();
            deleter.ActionName = "Delete site";
            if (sites_list.SelectedIndex != -1)
            {
                deleter.SiteName = ((Site)sites_list.SelectedItem).Name;
                deleter.SelectedCategoryId = categories_list.SelectedIndex;
            }
            foreach (Category category in categories_list.Items)
            {
                deleter.Categories.Add(category);
            }
            if (deleter.ShowDialog() == DialogResult.OK)
            {
                string siteName = deleter.SiteName;
                int CategoryId = deleter.SelectedCategoryId;
                DataRow[] rows = _dataSet.Tables[1].Select($"CategoryId = \'{CategoryId}\' AND Name = \'{siteName}\'");
                if (rows.Length != 0)
                {
                    foreach (DataRow row in rows)
                    {
                        _dataSet.Tables[1].Rows.Remove(row);
                    }
                    MessageBox.Show("Deleted!");
                }
                else
                {
                    MessageBox.Show("Not finded!");
                }
                
                _dataSet.AcceptChanges();
                _adapter.Update(_dataSet.Tables[1]);
                LoadSites();
            }
            }

        private void editSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sites_list.SelectedIndex != -1 && categories_list.SelectedIndex!=-1)
            {
                SitesEditor editor = new SitesEditor();
                foreach (Category category in categories_list.Items)
                {
                    editor.Categories.Add(category);
                }
                editor.ActionName = "Edit site";
                editor.SiteName = ((Site)sites_list.SelectedItem).Name.Clone().ToString();
                editor.AddressName = ((Site)sites_list.SelectedItem).Addr.Clone().ToString();
                editor.SelectedCategoryIndex = categories_list.SelectedIndex;
               
                if (editor.ShowDialog() == DialogResult.OK)
                {
                    DataRow[] rows = _dataSet.Tables[1].Select($"CategoryId = \'{((Category)categories_list.SelectedItem).Id}\' AND Name = \'{((Site)sites_list.SelectedItem).Name}\' AND Addr = \'{((Site)sites_list.SelectedItem).Addr}\'");
                   // MessageBox.Show($"Awaiting id -> {rows[0]["CategoryId"].ToString()}; Id -> {((Category)categories_list.SelectedItem).Id} ");
                    if (rows.Length > 0)
                    {
                        string newName = editor.SiteName;
                        string newAddress = editor.AddressName;
                        int NewCategoryIndex = editor.SelectedCategoryId;
                        foreach(DataRow row in rows)
                        {
                            row["Name"] = newName;
                            row["Addr"] = newAddress;
                            row["CategoryId"] = NewCategoryIndex;
                        }
                        _dataSet.AcceptChanges();
                        _adapter.Update(_dataSet);
                        LoadSites();
                        MessageBox.Show("Updating successful");
                    }
                    else
                        MessageBox.Show("Internal error!\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Site not selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
