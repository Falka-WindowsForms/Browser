using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser
{
    public partial class CategoriesEditor : Form
    {
        public string ActionName { get; set; }
        public string CategoryName { get; set;s }
        public CategoriesEditor()
        {
            InitializeComponent();
        }

        private void action_button_Click(object sender, EventArgs e)
        {

        }

        private void CategoriesEditor_Load(object sender, EventArgs e)
        {
            action_button.Text = ActionName;
        }
    }
}
