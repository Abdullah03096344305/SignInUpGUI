
namespace SignInUpWeek99
{
    partial class BurgerMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BurgerListView = new System.Windows.Forms.ListView();
            this.Burger_Names = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Burger_Prices = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(17, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(393, 79);
            this.label4.TabIndex = 11;
            this.label4.Text = "Smash  Burgers";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(390, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 58);
            this.label1.TabIndex = 12;
            this.label1.Text = "California";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(49, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "A Taste you\'ll Remeber";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BurgerListView
            // 
            this.BurgerListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BurgerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Burger_Names,
            this.Burger_Prices});
            this.BurgerListView.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BurgerListView.ForeColor = System.Drawing.Color.Maroon;
            this.BurgerListView.HideSelection = false;
            this.BurgerListView.Location = new System.Drawing.Point(12, 141);
            this.BurgerListView.Name = "BurgerListView";
            this.BurgerListView.Size = new System.Drawing.Size(398, 275);
            this.BurgerListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.BurgerListView.TabIndex = 20;
            this.BurgerListView.UseCompatibleStateImageBehavior = false;
            this.BurgerListView.View = System.Windows.Forms.View.Details;
            this.BurgerListView.SelectedIndexChanged += new System.EventHandler(this.BurgerListView_SelectedIndexChanged);
            // 
            // Burger_Names
            // 
            this.Burger_Names.Text = "Burger Names";
            this.Burger_Names.Width = 200;
            // 
            // Burger_Prices
            // 
            this.Burger_Prices.Text = "Burger Prices";
            this.Burger_Prices.Width = 100;
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Location = new System.Drawing.Point(574, 276);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.Size = new System.Drawing.Size(165, 20);
            this.textBoxTotalPrice.TabIndex = 21;
            this.textBoxTotalPrice.TextChanged += new System.EventHandler(this.textBoxTotalPrice_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Total Price";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(574, 186);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(165, 20);
            this.textBoxQuantity.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Quantity";
            // 
            // BurgerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTotalPrice);
            this.Controls.Add(this.BurgerListView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "BurgerMenu";
            this.Text = "BurgerMenu";
            this.Load += new System.EventHandler(this.BurgerMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView BurgerListView;
        private System.Windows.Forms.ColumnHeader Burger_Names;
        private System.Windows.Forms.ColumnHeader Burger_Prices;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label label3;
    }
}