using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Browser.Models;

namespace Browser
{
    public partial class DeleteSiteForm : Form
    {
        public List<Category> Categories;
        public string ActionName { get; set; }
        public string SiteName { get; set; }
        public int SelectedCategoryId { get; set; }
        public DeleteSiteForm()
        {
            InitializeComponent();
            Categories = new List<Category>();
            SelectedCategoryId = -1;


        }
        private void action_button_Click(object sender, EventArgs e)
        {
            SiteName = site_name_textBox.Text;
            if (!String.IsNullOrWhiteSpace(SiteName) && categories_list.SelectedIndex != -1)
            {
                SelectedCategoryId = (categories_list.SelectedItem as Category).Id;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Wrong input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteSiteForm_Load(object sender, EventArgs e)
        {
            action_button.Text = ActionName;
            foreach (Category category in Categories)
                categories_list.Items.Add(category);
            categories_list.DisplayMember = "Name";
            categories_list.SelectedIndex = SelectedCategoryId;
            site_name_textBox.Text = SiteName;
        }
    }
}
