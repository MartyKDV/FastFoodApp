namespace FastFoodApp
{
    partial class CustomerLobby
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
            this.lbWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbWelcome
            // 
            this.lbWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbWelcome.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.Location = new System.Drawing.Point(190, 56);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(433, 39);
            this.lbWelcome.TabIndex = 0;
            this.lbWelcome.Text = "Welcome to AUBG FastFood ";
            // 
            // CustomerLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbWelcome);
            this.Name = "CustomerLobby";
            this.Text = "CustomerLobby";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerLobby_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWelcome;
    }
}