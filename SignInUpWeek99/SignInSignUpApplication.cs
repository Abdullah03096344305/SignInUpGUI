using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using SignInUpWeek99.DL;
using SignInUpWeek99.BL;
/*using SignInUpWeek99.IO;*/
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignInUpWeek99
{
    public partial class SignInSignUpApplication : Form
    {
        public SignInSignUpApplication()
        {
            InitializeComponent();
            string path = "data.txt";
            if(MUserDL.ReadDataFromFile(path))
            {
                MessageBox.Show("Data Loaded from The File");
            }
            else
            {
                MessageBox.Show("Data Not Loaded");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(SignIn.Checked )
            {
                Form moreForm = new SignIn();
                moreForm.Show();
                SignUp.Checked = false;
            }
            else if (SignUp.Checked)
            {
                Form moreForm = new SignUp();
                moreForm.Show();
                SignUp.Checked = false;
            }
        }
        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
