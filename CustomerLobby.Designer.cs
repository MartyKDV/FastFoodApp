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
            this.tabCustomerOptions = new System.Windows.Forms.TabControl();
            this.viewProducts = new System.Windows.Forms.TabPage();
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.productColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ingredientsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewOrder = new System.Windows.Forms.TabPage();
            this.flowLayoutOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCustom = new System.Windows.Forms.Button();
            this.btnEmptyCart = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.tabCustomerOptions.SuspendLayout();
            this.viewProducts.SuspendLayout();
            this.viewOrder.SuspendLayout();
            this.flowLayoutOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCustomerOptions
            // 
            this.tabCustomerOptions.Controls.Add(this.viewProducts);
            this.tabCustomerOptions.Controls.Add(this.viewOrder);
            this.tabCustomerOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCustomerOptions.Location = new System.Drawing.Point(0, 0);
            this.tabCustomerOptions.Name = "tabCustomerOptions";
            this.tabCustomerOptions.SelectedIndex = 0;
            this.tabCustomerOptions.Size = new System.Drawing.Size(585, 366);
            this.tabCustomerOptions.TabIndex = 1;
            // 
            // viewProducts
            // 
            this.viewProducts.Controls.Add(this.listViewProducts);
            this.viewProducts.Location = new System.Drawing.Point(4, 22);
            this.viewProducts.Name = "viewProducts";
            this.viewProducts.Padding = new System.Windows.Forms.Padding(3);
            this.viewProducts.Size = new System.Drawing.Size(577, 340);
            this.viewProducts.TabIndex = 0;
            this.viewProducts.Text = "View Products";
            this.viewProducts.UseVisualStyleBackColor = true;
            this.viewProducts.Click += new System.EventHandler(this.tabPage1_Click);
            this.viewProducts.Enter += new System.EventHandler(this.viewProducts_Enter);
            // 
            // listViewProducts
            // 
            this.listViewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productColumn,
            this.ingredientsColumn,
            this.priceColumn});
            this.listViewProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewProducts.GridLines = true;
            this.listViewProducts.HideSelection = false;
            this.listViewProducts.Location = new System.Drawing.Point(3, 3);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(571, 334);
            this.listViewProducts.TabIndex = 1;
            this.listViewProducts.TileSize = new System.Drawing.Size(220, 80);
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.View = System.Windows.Forms.View.Details;
            // 
            // productColumn
            // 
            this.productColumn.Text = "Product";
            this.productColumn.Width = 164;
            // 
            // ingredientsColumn
            // 
            this.ingredientsColumn.Text = "Ingredients";
            this.ingredientsColumn.Width = 358;
            // 
            // priceColumn
            // 
            this.priceColumn.Text = "Price";
            this.priceColumn.Width = 45;
            // 
            // viewOrder
            // 
            this.viewOrder.Controls.Add(this.flowLayoutOrders);
            this.viewOrder.Location = new System.Drawing.Point(4, 22);
            this.viewOrder.Name = "viewOrder";
            this.viewOrder.Padding = new System.Windows.Forms.Padding(3);
            this.viewOrder.Size = new System.Drawing.Size(577, 340);
            this.viewOrder.TabIndex = 1;
            this.viewOrder.Text = "Order";
            this.viewOrder.UseVisualStyleBackColor = true;
            this.viewOrder.Enter += new System.EventHandler(this.viewOrder_Enter);
            // 
            // flowLayoutOrders
            // 
            this.flowLayoutOrders.AutoScroll = true;
            this.flowLayoutOrders.AutoSize = true;
            this.flowLayoutOrders.Controls.Add(this.label1);
            this.flowLayoutOrders.Controls.Add(this.btnAddCustom);
            this.flowLayoutOrders.Controls.Add(this.btnEmptyCart);
            this.flowLayoutOrders.Controls.Add(this.btnCart);
            this.flowLayoutOrders.Controls.Add(this.btnOrder);
            this.flowLayoutOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutOrders.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutOrders.Name = "flowLayoutOrders";
            this.flowLayoutOrders.Size = new System.Drawing.Size(571, 334);
            this.flowLayoutOrders.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 45, 3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Custom";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddCustom
            // 
            this.btnAddCustom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddCustom.Location = new System.Drawing.Point(103, 45);
            this.btnAddCustom.Margin = new System.Windows.Forms.Padding(0, 45, 0, 3);
            this.btnAddCustom.Name = "btnAddCustom";
            this.btnAddCustom.Size = new System.Drawing.Size(40, 24);
            this.btnAddCustom.TabIndex = 1;
            this.btnAddCustom.Text = "Add";
            this.btnAddCustom.UseVisualStyleBackColor = true;
            this.btnAddCustom.Click += new System.EventHandler(this.btnAddCustom_Click);
            // 
            // btnEmptyCart
            // 
            this.btnEmptyCart.Location = new System.Drawing.Point(343, 10);
            this.btnEmptyCart.Margin = new System.Windows.Forms.Padding(200, 10, 0, 3);
            this.btnEmptyCart.Name = "btnEmptyCart";
            this.btnEmptyCart.Size = new System.Drawing.Size(47, 24);
            this.btnEmptyCart.TabIndex = 3;
            this.btnEmptyCart.Text = "Empty";
            this.btnEmptyCart.UseVisualStyleBackColor = true;
            this.btnEmptyCart.Click += new System.EventHandler(this.btnEmptyCart_Click);
            // 
            // btnCart
            // 
            this.btnCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCart.Location = new System.Drawing.Point(400, 10);
            this.btnCart.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(75, 23);
            this.btnCart.TabIndex = 2;
            this.btnCart.Text = "Cart";
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutOrders.SetFlowBreak(this.btnOrder, true);
            this.btnOrder.Location = new System.Drawing.Point(485, 10);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(60, 24);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // CustomerLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 366);
            this.Controls.Add(this.tabCustomerOptions);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerLobby";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerLobby";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerLobby_FormClosed);
            this.Load += new System.EventHandler(this.CustomerLobby_Load);
            this.tabCustomerOptions.ResumeLayout(false);
            this.viewProducts.ResumeLayout(false);
            this.viewOrder.ResumeLayout(false);
            this.viewOrder.PerformLayout();
            this.flowLayoutOrders.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCustomerOptions;
        private System.Windows.Forms.TabPage viewProducts;
        private System.Windows.Forms.TabPage viewOrder;
        private System.Windows.Forms.ListView listViewProducts;
        private System.Windows.Forms.ColumnHeader productColumn;
        private System.Windows.Forms.ColumnHeader ingredientsColumn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCustom;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnEmptyCart;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.ColumnHeader priceColumn;
    }
}