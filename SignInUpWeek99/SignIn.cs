using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using SignInUpWeek99.BL;
using SignInUpWeek99.DL;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignInUpWeek99
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
        private void CLearDataFromForm()
        {
            usernameText.Text = "";
            passwordText.Text = "";            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usernameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = usernameText.Text;
            string password = passwordText.Text;
            MUser user = new MUser(username, password);
            MUser validUser = MUserDL.SignIn(user);
            if(validUser != null)
            {
                /*MessageBox.Show("User is Valid ");*/
                Form moreForm = new AdminCheck();
                moreForm.Show();             

            }
            else
            {
                MessageBox.Show("User is Invalid ");
            }
            CLearDataFromForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
