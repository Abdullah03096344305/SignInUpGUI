﻿using System;
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
    public partial class BillMenu : Form
    {
        public BillMenu()
        {
            InitializeComponent();
        }

        private void BillMenu_Load(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxBill_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
