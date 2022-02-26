namespace FastFoodApp
{
    partial class EmployeeLogin
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
            this.lbEmployeeID = new System.Windows.Forms.Label();
            this.lbEmployeePassword = new System.Windows.Forms.Label();
            this.tbEmployeeID = new System.Windows.Forms.TextBox();
            this.tbEmployeePassword = new System.Windows.Forms.TextBox();
            this.btnEmployeeLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbEmployeeID
            // 
            this.lbEmployeeID.AutoSize = true;
            this.lbEmployeeID.Location = new System.Drawing.Point(33, 73);
            this.lbEmployeeID.Name = "lbEmployeeID";
            this.lbEmployeeID.Size = new System.Drawing.Size(87, 17);
            this.lbEmployeeID.TabIndex = 0;
            this.lbEmployeeID.Text = "Employee ID";
            // 
            // lbEmployeePassword
            // 
            this.lbEmployeePassword.AutoSize = true;
            this.lbEmployeePassword.Location = new System.Drawing.Point(33, 114);
            this.lbEmployeePassword.Name = "lbEmployeePassword";
            this.lbEmployeePassword.Size = new System.Drawing.Size(69, 17);
            this.lbEmployeePassword.TabIndex = 1;
            this.lbEmployeePassword.Text = "Password";
            // 
            // tbEmployeeID
            // 
            this.tbEmployeeID.Location = new System.Drawing.Point(126, 70);
            this.tbEmployeeID.Name = "tbEmployeeID";
            this.tbEmployeeID.Size = new System.Drawing.Size(129, 22);
            this.tbEmployeeID.TabIndex = 2;
            // 
            // tbEmployeePassword
            // 
            this.tbEmployeePassword.Location = new System.Drawing.Point(126, 111);
            this.tbEmployeePassword.Name = "tbEmployeePassword";
            this.tbEmployeePassword.PasswordChar = '*';
            this.tbEmployeePassword.Size = new System.Drawing.Size(129, 22);
            this.tbEmployeePassword.TabIndex = 3;
            // 
            // btnEmployeeLogin
            // 
            this.btnEmployeeLogin.Location = new System.Drawing.Point(105, 161);
            this.btnEmployeeLogin.Name = "btnEmployeeLogin";
            this.btnEmployeeLogin.Size = new System.Drawing.Size(75, 34);
            this.btnEmployeeLogin.TabIndex = 4;
            this.btnEmployeeLogin.Text = "Login";
            this.btnEmployeeLogin.UseVisualStyleBackColor = true;
            this.btnEmployeeLogin.Click += new System.EventHandler(this.btnEmployeeLogin_Click);
            // 
            // EmployeeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 217);
            this.Controls.Add(this.btnEmployeeLogin);
            this.Controls.Add(this.tbEmployeePassword);
            this.Controls.Add(this.tbEmployeeID);
            this.Controls.Add(this.lbEmployeePassword);
            this.Controls.Add(this.lbEmployeeID);
            this.Name = "EmployeeLogin";
            this.Text = "EmployeeLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEmployeeID;
        private System.Windows.Forms.Label lbEmployeePassword;
        private System.Windows.Forms.TextBox tbEmployeeID;
        private System.Windows.Forms.TextBox tbEmployeePassword;
        private System.Windows.Forms.Button btnEmployeeLogin;
    }
}