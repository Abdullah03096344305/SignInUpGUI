﻿using SignInUpWeek99.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignInUpWeek99
{
    public partial class BurgerMenu : Form
    {

        public int totalPrice ;       

        public BurgerMenu()
        {
            InitializeComponent();
          
        }

     

        public int GetBurgerPrice()
        {
            return totalPrice;
        }
       

       

        private void BurgerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        private void BurgerMenu_Load(object sender, EventArgs e)
        {
            string burgerPath = "burgerFile.txt";
            BurgerDL.ReadBurgerFile(burgerPath, BurgerListView);
        }
        public void BurgerListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BurgerListView.SelectedItems.Count > 0)
            {               
                foreach (ListViewItem selectedItem in BurgerListView.SelectedItems)
                {
                    int price;
                    int quantity;
                    if (int.TryParse(selectedItem.SubItems[1].Text, out price) && int.TryParse(textBoxQuantity.Text, out quantity))
                    {
                        int itemTotal = price * quantity;
                        totalPrice += itemTotal;
                    }
                }
                textBoxTotalPrice.Text = GetBurgerPrice().ToString();
              
            }
          
        }

        private void textBoxTotalPrice_TextChanged(object sender, EventArgs e)
        {
            textBoxQuantity.Text = " ";
        }
    }
}
