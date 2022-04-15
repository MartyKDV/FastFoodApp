
namespace FastFoodApp
{
    partial class ManagerLobby
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
            this.tabManagerOptions = new System.Windows.Forms.TabControl();
            this.viewManageEmployees = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelManageEmployees = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.tabPageViewRequests = new System.Windows.Forms.TabPage();
            this.tabManagerOptions.SuspendLayout();
            this.viewManageEmployees.SuspendLayout();
            this.flowLayoutPanelManageEmployees.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabManagerOptions
            // 
            this.tabManagerOptions.Controls.Add(this.viewManageEmployees);
            this.tabManagerOptions.Controls.Add(this.tabPageViewRequests);
            this.tabManagerOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabManagerOptions.Location = new System.Drawing.Point(0, 0);
            this.tabManagerOptions.Name = "tabManagerOptions";
            this.tabManagerOptions.SelectedIndex = 0;
            this.tabManagerOptions.Size = new System.Drawing.Size(585, 366);
            this.tabManagerOptions.TabIndex = 0;
            // 
            // viewManageEmployees
            // 
            this.viewManageEmployees.Controls.Add(this.flowLayoutPanelManageEmployees);
            this.viewManageEmployees.Location = new System.Drawing.Point(4, 22);
            this.viewManageEmployees.Name = "viewManageEmployees";
            this.viewManageEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.viewManageEmployees.Size = new System.Drawing.Size(577, 340);
            this.viewManageEmployees.TabIndex = 0;
            this.viewManageEmployees.Text = "Manage Employees";
            this.viewManageEmployees.UseVisualStyleBackColor = true;
            this.viewManageEmployees.Enter += new System.EventHandler(this.viewManageEmployees_Enter);
            // 
            // flowLayoutPanelManageEmployees
            // 
            this.flowLayoutPanelManageEmployees.Controls.Add(this.btnAddEmployee);
            this.flowLayoutPanelManageEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelManageEmployees.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelManageEmployees.Name = "flowLayoutPanelManageEmployees";
            this.flowLayoutPanelManageEmployees.Size = new System.Drawing.Size(571, 334);
            this.flowLayoutPanelManageEmployees.TabIndex = 0;
            // 
            // btnAddEmployee
            // 
            this.flowLayoutPanelManageEmployees.SetFlowBreak(this.btnAddEmployee, true);
            this.btnAddEmployee.Location = new System.Drawing.Point(450, 10);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(450, 10, 3, 3);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(90, 24);
            this.btnAddEmployee.TabIndex = 0;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            // 
            // tabPageViewRequests
            // 
            this.tabPageViewRequests.Location = new System.Drawing.Point(4, 22);
            this.tabPageViewRequests.Name = "tabPageViewRequests";
            this.tabPageViewRequests.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageViewRequests.Size = new System.Drawing.Size(577, 340);
            this.tabPageViewRequests.TabIndex = 1;
            this.tabPageViewRequests.Text = "View Requests";
            this.tabPageViewRequests.UseVisualStyleBackColor = true;
            // 
            // ManagerLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 366);
            this.Controls.Add(this.tabManagerOptions);
            this.Name = "ManagerLobby";
            this.Text = "ManagerLobby";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagerLobby_FormClosed);
            this.Load += new System.EventHandler(this.ManagerLobby_Load);
            this.tabManagerOptions.ResumeLayout(false);
            this.viewManageEmployees.ResumeLayout(false);
            this.flowLayoutPanelManageEmployees.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabManagerOptions;
        private System.Windows.Forms.TabPage viewManageEmployees;
        private System.Windows.Forms.TabPage tabPageViewRequests;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelManageEmployees;
        private System.Windows.Forms.Button btnAddEmployee;
    }
}