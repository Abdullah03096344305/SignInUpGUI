using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using SignInUpWeek99.BL;
using SignInUpWeek99.DL;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignInUpWeek99
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        private void CLearDataFromForm()
        {
            usernameText.Text = "";
            passwordText.Text = "";
            roleText.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameText.Text;
            string password = passwordText.Text;
            string role = roleText.Text;
            string path = "data.txt";
            MUser user = new MUser(username, password, role);
            MUserDL.AddUserIntoList(user);
            MUserDL.StoreUserIntoFile(user, path);
            MessageBox.Show("User Added SuccessFully");
            CLearDataFromForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
