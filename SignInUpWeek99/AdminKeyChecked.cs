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
    public partial class AdminKeyChecked : Form
    {
        string adminkey = "555";

        public AdminKeyChecked()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CLearDataFromForm()
        {
            txtAdminCheck.Text = "";          
        }

        private void txtAdminCheck_TextChanged(object sender, EventArgs e)
        {
           
           
           
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string AdminKey = txtAdminCheck.Text;
            if (adminkey == AdminKey)
            {
                MessageBox.Show("Admin Key is Valid");
            }
            else
            {
                MessageBox.Show("Admin Key is Inalid");
            }
            CLearDataFromForm();
        }
    }
}
