using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignInUpWeek99
{
    public partial class AdminCheck : Form
    {
        public AdminCheck()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {  
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonCustomer_CheckedChanged(object sender, EventArgs e)
        {           
        }        
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (radioButtonAdmin.Checked)
            {
                Form moreForm = new AdminKeyChecked();
                moreForm.Show();
                radioButtonCustomer.Checked = false;
            }
            else if (radioButtonCustomer.Checked)
            {
                Form moreForm = new UserMenu();
                moreForm.Show();
                radioButtonAdmin.Checked = false;
            }
        }
    }
}
