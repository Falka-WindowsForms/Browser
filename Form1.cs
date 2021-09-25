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
                foreach(DataRow row in _dataSet.Tables[0].Rows)
                {
                    if (row["Name"].ToString() == categoryName)
                    {
                        row.Delete();
                        MessageBox.Show("Category deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                _adapter.Update(_dataSet.Tables[0]);
                LoadCategories();
            }
        }
    }
}
