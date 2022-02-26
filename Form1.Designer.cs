﻿
namespace FastFoodApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnLogin = new System.Windows.Forms.Button();
            this.registerCustomer = new System.Windows.Forms.Button();
            this.btnEmployeeLogin = new System.Windows.Forms.Button();
            this.btnManagerLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(226, 113);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(4);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(132, 22);
            this.tbUsername.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(226, 161);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(132, 22);
            this.tbPassword.TabIndex = 1;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(147, 116);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(73, 17);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(147, 164);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(69, 17);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(150, 214);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 28);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // registerCustomer
            // 
            this.registerCustomer.Location = new System.Drawing.Point(259, 214);
            this.registerCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.registerCustomer.Name = "registerCustomer";
            this.registerCustomer.Size = new System.Drawing.Size(100, 28);
            this.registerCustomer.TabIndex = 5;
            this.registerCustomer.Text = "Register";
            this.registerCustomer.UseVisualStyleBackColor = true;
            this.registerCustomer.Click += new System.EventHandler(this.registerCustomer_Click);
            // 
            // btnEmployeeLogin
            // 
            this.btnEmployeeLogin.Location = new System.Drawing.Point(150, 334);
            this.btnEmployeeLogin.Name = "btnEmployeeLogin";
            this.btnEmployeeLogin.Size = new System.Drawing.Size(209, 43);
            this.btnEmployeeLogin.TabIndex = 6;
            this.btnEmployeeLogin.Text = "Employee Login";
            this.btnEmployeeLogin.UseVisualStyleBackColor = true;
            this.btnEmployeeLogin.Click += new System.EventHandler(this.btnEmployeeLogin_Click);
            // 
            // btnManagerLogin
            // 
            this.btnManagerLogin.Location = new System.Drawing.Point(150, 407);
            this.btnManagerLogin.Name = "btnManagerLogin";
            this.btnManagerLogin.Size = new System.Drawing.Size(209, 43);
            this.btnManagerLogin.TabIndex = 7;
            this.btnManagerLogin.Text = "Manager Login";
            this.btnManagerLogin.UseVisualStyleBackColor = true;
            this.btnManagerLogin.Click += new System.EventHandler(this.btnManagerLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(391, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(493, 440);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(938, 548);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnManagerLogin);
            this.Controls.Add(this.btnEmployeeLogin);
            this.Controls.Add(this.registerCustomer);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "FastFoodApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button registerCustomer;
        private System.Windows.Forms.Button btnEmployeeLogin;
        private System.Windows.Forms.Button btnManagerLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

