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
    public partial class UserMenu : Form
    {
        private BillMenu billMenuForm;       
        public UserMenu()
        {
            InitializeComponent();
        }

        private void labelBurger_Click(object sender, EventArgs e)
        {
            Form moreForm = new BurgerMenu();
            moreForm.Show();
        }

        private void labelDeals_Click(object sender, EventArgs e)
        {
            Form moreForm = new DealMenu();
            moreForm.Show();
        }
    }
}
