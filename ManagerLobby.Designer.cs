
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabManagerOptions = new System.Windows.Forms.TabControl();
            this.viewManageEmployees = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelManageEmployees = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPageViewRequests = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridViewRestock = new System.Windows.Forms.DataGridView();
            this.columnFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIngredientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.columnButtonDismiss = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPageOrderHistory = new System.Windows.Forms.TabPage();
            this.dataGridViewOrderHistory = new System.Windows.Forms.DataGridView();
            this.columnCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabManagerOptions.SuspendLayout();
            this.viewManageEmployees.SuspendLayout();
            this.flowLayoutPanelManageEmployees.SuspendLayout();
            this.tabPageViewRequests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRestock)).BeginInit();
            this.tabPageOrderHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // tabManagerOptions
            // 
            this.tabManagerOptions.Controls.Add(this.viewManageEmployees);
            this.tabManagerOptions.Controls.Add(this.tabPageViewRequests);
            this.tabManagerOptions.Controls.Add(this.tabPageOrderHistory);
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
            this.flowLayoutPanelManageEmployees.AutoScroll = true;
            this.flowLayoutPanelManageEmployees.AutoSize = true;
            this.flowLayoutPanelManageEmployees.Controls.Add(this.btnAddEmployee);
            this.flowLayoutPanelManageEmployees.Controls.Add(this.label1);
            this.flowLayoutPanelManageEmployees.Controls.Add(this.label2);
            this.flowLayoutPanelManageEmployees.Controls.Add(this.label3);
            this.flowLayoutPanelManageEmployees.Controls.Add(this.label4);
            this.flowLayoutPanelManageEmployees.Controls.Add(this.label5);
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
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(82, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(163, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(244, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Age";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(325, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Position";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageViewRequests
            // 
            this.tabPageViewRequests.Controls.Add(this.btnRefresh);
            this.tabPageViewRequests.Controls.Add(this.dataGridViewRestock);
            this.tabPageViewRequests.Location = new System.Drawing.Point(4, 22);
            this.tabPageViewRequests.Name = "tabPageViewRequests";
            this.tabPageViewRequests.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageViewRequests.Size = new System.Drawing.Size(577, 340);
            this.tabPageViewRequests.TabIndex = 1;
            this.tabPageViewRequests.Text = "View Requests";
            this.tabPageViewRequests.UseVisualStyleBackColor = true;
            this.tabPageViewRequests.Enter += new System.EventHandler(this.tabPageViewRequests_Enter);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(504, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(65, 29);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataGridViewRestock
            // 
            this.dataGridViewRestock.AllowUserToAddRows = false;
            this.dataGridViewRestock.AllowUserToDeleteRows = false;
            this.dataGridViewRestock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRestock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewRestock.ColumnHeadersHeight = 34;
            this.dataGridViewRestock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnFirstName,
            this.columnLastName,
            this.columnIngredientName,
            this.columnQuantity,
            this.columnButton,
            this.columnButtonDismiss});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRestock.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRestock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRestock.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewRestock.MinimumSize = new System.Drawing.Size(0, 31);
            this.dataGridViewRestock.Name = "dataGridViewRestock";
            this.dataGridViewRestock.ReadOnly = true;
            this.dataGridViewRestock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewRestock.RowTemplate.DividerHeight = 2;
            this.dataGridViewRestock.RowTemplate.Height = 40;
            this.dataGridViewRestock.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewRestock.Size = new System.Drawing.Size(571, 334);
            this.dataGridViewRestock.TabIndex = 0;
            this.dataGridViewRestock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRestock_CellContentClick);
            // 
            // columnFirstName
            // 
            this.columnFirstName.FillWeight = 44F;
            this.columnFirstName.HeaderText = "First Name";
            this.columnFirstName.Name = "columnFirstName";
            this.columnFirstName.ReadOnly = true;
            // 
            // columnLastName
            // 
            this.columnLastName.FillWeight = 44F;
            this.columnLastName.HeaderText = "Last Name";
            this.columnLastName.Name = "columnLastName";
            this.columnLastName.ReadOnly = true;
            // 
            // columnIngredientName
            // 
            this.columnIngredientName.FillWeight = 44F;
            this.columnIngredientName.HeaderText = "Ingredient";
            this.columnIngredientName.Name = "columnIngredientName";
            this.columnIngredientName.ReadOnly = true;
            // 
            // columnQuantity
            // 
            this.columnQuantity.FillWeight = 25F;
            this.columnQuantity.HeaderText = "Quantity";
            this.columnQuantity.Name = "columnQuantity";
            this.columnQuantity.ReadOnly = true;
            this.columnQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // columnButton
            // 
            this.columnButton.FillWeight = 30F;
            this.columnButton.HeaderText = "";
            this.columnButton.Name = "columnButton";
            this.columnButton.ReadOnly = true;
            this.columnButton.Text = "Approve";
            this.columnButton.UseColumnTextForButtonValue = true;
            // 
            // columnButtonDismiss
            // 
            this.columnButtonDismiss.FillWeight = 30F;
            this.columnButtonDismiss.HeaderText = "";
            this.columnButtonDismiss.Name = "columnButtonDismiss";
            this.columnButtonDismiss.ReadOnly = true;
            this.columnButtonDismiss.Text = "Dismiss";
            this.columnButtonDismiss.UseColumnTextForButtonValue = true;
            // 
            // tabPageOrderHistory
            // 
            this.tabPageOrderHistory.Controls.Add(this.dataGridViewOrderHistory);
            this.tabPageOrderHistory.Location = new System.Drawing.Point(4, 22);
            this.tabPageOrderHistory.Name = "tabPageOrderHistory";
            this.tabPageOrderHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrderHistory.Size = new System.Drawing.Size(577, 340);
            this.tabPageOrderHistory.TabIndex = 2;
            this.tabPageOrderHistory.Text = "Order History";
            this.tabPageOrderHistory.UseVisualStyleBackColor = true;
            this.tabPageOrderHistory.Enter += new System.EventHandler(this.tabPageOrderHistory_Enter);
            // 
            // dataGridViewOrderHistory
            // 
            this.dataGridViewOrderHistory.AllowUserToAddRows = false;
            this.dataGridViewOrderHistory.AllowUserToDeleteRows = false;
            this.dataGridViewOrderHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrderHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewOrderHistory.ColumnHeadersHeight = 34;
            this.dataGridViewOrderHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewOrderHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnCustomer,
            this.columnOrder,
            this.columnPrice,
            this.columnEmployee});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrderHistory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOrderHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOrderHistory.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewOrderHistory.Name = "dataGridViewOrderHistory";
            this.dataGridViewOrderHistory.ReadOnly = true;
            this.dataGridViewOrderHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewOrderHistory.RowTemplate.DividerHeight = 2;
            this.dataGridViewOrderHistory.RowTemplate.Height = 40;
            this.dataGridViewOrderHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewOrderHistory.Size = new System.Drawing.Size(571, 334);
            this.dataGridViewOrderHistory.TabIndex = 0;
            // 
            // columnCustomer
            // 
            this.columnCustomer.HeaderText = "Customer Name";
            this.columnCustomer.Name = "columnCustomer";
            this.columnCustomer.ReadOnly = true;
            // 
            // columnOrder
            // 
            this.columnOrder.HeaderText = "Order";
            this.columnOrder.Name = "columnOrder";
            this.columnOrder.ReadOnly = true;
            // 
            // columnPrice
            // 
            this.columnPrice.HeaderText = "Total Price";
            this.columnPrice.Name = "columnPrice";
            this.columnPrice.ReadOnly = true;
            // 
            // columnEmployee
            // 
            this.columnEmployee.HeaderText = "Employee Name";
            this.columnEmployee.Name = "columnEmployee";
            this.columnEmployee.ReadOnly = true;
            // 
            // ManagerLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 366);
            this.Controls.Add(this.tabManagerOptions);
            this.Name = "ManagerLobby";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerLobby";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagerLobby_FormClosed);
            this.Load += new System.EventHandler(this.ManagerLobby_Load);
            this.tabManagerOptions.ResumeLayout(false);
            this.viewManageEmployees.ResumeLayout(false);
            this.viewManageEmployees.PerformLayout();
            this.flowLayoutPanelManageEmployees.ResumeLayout(false);
            this.tabPageViewRequests.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRestock)).EndInit();
            this.tabPageOrderHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabManagerOptions;
        private System.Windows.Forms.TabPage viewManageEmployees;
        private System.Windows.Forms.TabPage tabPageViewRequests;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelManageEmployees;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewRestock;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIngredientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnQuantity;
        private System.Windows.Forms.DataGridViewButtonColumn columnButton;
        private System.Windows.Forms.DataGridViewButtonColumn columnButtonDismiss;
        private System.Windows.Forms.TabPage tabPageOrderHistory;
        private System.Windows.Forms.DataGridView dataGridViewOrderHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEmployee;
    }
}