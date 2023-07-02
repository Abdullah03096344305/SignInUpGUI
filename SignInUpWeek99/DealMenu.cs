using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using SignInUpWeek99.BL;
using SignInUpWeek99.DL;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignInUpWeek99
{
    public partial class DealMenu : Form
    {
        private int dealtotalPrice = 0;      
        public DealMenu()
        {
            InitializeComponent();
         
        }
        public int GetDealPrice()
        {
            return dealtotalPrice;
        }


        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        public void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DealListView.SelectedItems.Count > 0)
            {

                foreach (ListViewItem selectedItem in DealListView.SelectedItems)
                {
                    int price;
                    int quantity;
                    if (int.TryParse(selectedItem.SubItems[1].Text, out price) && int.TryParse(textBoxQuantity.Text, out quantity))
                    {
                        int itemTotal = price * quantity;
                        dealtotalPrice += itemTotal;
                    }
                }
                textBoxTotalPrice.Text = GetDealPrice().ToString();               
            }           
        }

        private void DealMenu_Load(object sender, EventArgs e)
        {
            string dealPath = "dealFile.txt";
            DealDL.ReadDealFile(dealPath,DealListView);
        }
    }
}
