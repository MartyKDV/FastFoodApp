namespace FastFoodApp
{
    partial class ManagerLogin
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
            this.btnManagerLogin = new System.Windows.Forms.Button();
            this.tbManagerPassword = new System.Windows.Forms.TextBox();
            this.tbManagerID = new System.Windows.Forms.TextBox();
            this.lbManagerPassword = new System.Windows.Forms.Label();
            this.lbManagerID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnManagerLogin
            // 
            this.btnManagerLogin.Location = new System.Drawing.Point(79, 131);
            this.btnManagerLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnManagerLogin.Name = "btnManagerLogin";
            this.btnManagerLogin.Size = new System.Drawing.Size(56, 28);
            this.btnManagerLogin.TabIndex = 9;
            this.btnManagerLogin.Text = "Login";
            this.btnManagerLogin.UseVisualStyleBackColor = true;
            this.btnManagerLogin.Click += new System.EventHandler(this.btnManagerLogin_Click);
            // 
            // tbManagerPassword
            // 
            this.tbManagerPassword.Location = new System.Drawing.Point(94, 90);
            this.tbManagerPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbManagerPassword.Name = "tbManagerPassword";
            this.tbManagerPassword.PasswordChar = '*';
            this.tbManagerPassword.Size = new System.Drawing.Size(98, 20);
            this.tbManagerPassword.TabIndex = 8;
            // 
            // tbManagerID
            // 
            this.tbManagerID.Location = new System.Drawing.Point(94, 57);
            this.tbManagerID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbManagerID.Name = "tbManagerID";
            this.tbManagerID.Size = new System.Drawing.Size(98, 20);
            this.tbManagerID.TabIndex = 7;
            // 
            // lbManagerPassword
            // 
            this.lbManagerPassword.AutoSize = true;
            this.lbManagerPassword.Location = new System.Drawing.Point(25, 93);
            this.lbManagerPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbManagerPassword.Name = "lbManagerPassword";
            this.lbManagerPassword.Size = new System.Drawing.Size(53, 13);
            this.lbManagerPassword.TabIndex = 6;
            this.lbManagerPassword.Text = "Password";
            // 
            // lbManagerID
            // 
            this.lbManagerID.AutoSize = true;
            this.lbManagerID.Location = new System.Drawing.Point(25, 59);
            this.lbManagerID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbManagerID.Name = "lbManagerID";
            this.lbManagerID.Size = new System.Drawing.Size(63, 13);
            this.lbManagerID.TabIndex = 5;
            this.lbManagerID.Text = "Manager ID";
            // 
            // ManagerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 176);
            this.Controls.Add(this.btnManagerLogin);
            this.Controls.Add(this.tbManagerPassword);
            this.Controls.Add(this.tbManagerID);
            this.Controls.Add(this.lbManagerPassword);
            this.Controls.Add(this.lbManagerID);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManagerLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManagerLogin;
        private System.Windows.Forms.TextBox tbManagerPassword;
        private System.Windows.Forms.TextBox tbManagerID;
        private System.Windows.Forms.Label lbManagerPassword;
        private System.Windows.Forms.Label lbManagerID;
    }
}