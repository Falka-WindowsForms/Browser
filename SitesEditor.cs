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
    public partial class SitesEditor : Form
    {
        public SitesEditor()
        {
            InitializeComponent();
            Categories = new List<Category>();
        }
        public string ActionName { get; set; }
        public string SiteName { get; set; }
        public string AddressName { get; set; }
        public int SelectedCategoryId { get;set; }
        public List<Category> Categories { get; set; }

        private void SitesEditor_Load(object sender, EventArgs e)
        {
            action_button.Text = ActionName;
            foreach(Category category in Categories)
                categories_list.Items.Add(category);
            categories_list.DisplayMember = "Name";
        }

        private void action_button_Click(object sender, EventArgs e)
        {
            SiteName = name_field.Text;
            AddressName = address_field.Text;
            if(!String.IsNullOrWhiteSpace(SiteName) && !String.IsNullOrWhiteSpace(AddressName) && categories_list.SelectedIndex != -1)
            {
                SelectedCategoryId = (categories_list.SelectedItem as Category).Id;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Wrong input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
