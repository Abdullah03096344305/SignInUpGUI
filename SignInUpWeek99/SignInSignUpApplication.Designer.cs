﻿
namespace SignInUpWeek99
{
    partial class SignInSignUpApplication
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
            this.label1 = new System.Windows.Forms.Label();
            this.SignIn = new System.Windows.Forms.CheckBox();
            this.SignUp = new System.Windows.Forms.CheckBox();
            this.next_Click = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "Smash  Burgers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SignIn
            // 
            this.SignIn.AutoSize = true;
            this.SignIn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SignIn.Location = new System.Drawing.Point(99, 273);
            this.SignIn.Margin = new System.Windows.Forms.Padding(6);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(91, 28);
            this.SignIn.TabIndex = 1;
            this.SignIn.Text = "Sign In";
            this.SignIn.UseVisualStyleBackColor = true;
            this.SignIn.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SignUp
            // 
            this.SignUp.AutoSize = true;
            this.SignUp.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SignUp.Location = new System.Drawing.Point(99, 324);
            this.SignUp.Margin = new System.Windows.Forms.Padding(6);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(99, 28);
            this.SignUp.TabIndex = 2;
            this.SignUp.Text = "Sign Up";
            this.SignUp.UseVisualStyleBackColor = true;
            this.SignUp.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // next_Click
            // 
            this.next_Click.Location = new System.Drawing.Point(214, 412);
            this.next_Click.Name = "next_Click";
            this.next_Click.Size = new System.Drawing.Size(102, 31);
            this.next_Click.TabIndex = 3;
            this.next_Click.Text = "Next";
            this.next_Click.UseVisualStyleBackColor = true;
            this.next_Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Magneto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(417, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 58);
            this.label2.TabIndex = 4;
            this.label2.Text = "California";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(94, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "A Taste you\'ll Remeber";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // SignInSignUpApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(918, 455);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.next_Click);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SignInSignUpApplication";
            this.Text = "Sign In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox SignIn;
        private System.Windows.Forms.CheckBox SignUp;
        private System.Windows.Forms.Button next_Click;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}