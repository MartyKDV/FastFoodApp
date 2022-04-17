
namespace FastFoodApp
{
    partial class EmployeeLobby
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
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.columnFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnProducts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControlEmployeeLobby = new System.Windows.Forms.TabControl();
            this.viewOrders = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.viewIngredients = new System.Windows.Forms.TabPage();
            this.comboBoxRestock = new System.Windows.Forms.ComboBox();
            this.btnRestock = new System.Windows.Forms.Button();
            this.listViewIngredients = new System.Windows.Forms.ListView();
            this.columnIngredientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.tabControlEmployeeLobby.SuspendLayout();
            this.viewOrders.SuspendLayout();
            this.viewIngredients.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnFirstName,
            this.columnLastName,
            this.columnProducts,
            this.columnTotalPrice,
            this.columnButton});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrders.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOrders.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewOrders.RowTemplate.DividerHeight = 2;
            this.dataGridViewOrders.RowTemplate.Height = 40;
            this.dataGridViewOrders.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewOrders.Size = new System.Drawing.Size(571, 334);
            this.dataGridViewOrders.TabIndex = 0;
            this.dataGridViewOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrders_CellContentClick);
            // 
            // columnFirstName
            // 
            this.columnFirstName.FillWeight = 48.43219F;
            this.columnFirstName.HeaderText = "First Name";
            this.columnFirstName.Name = "columnFirstName";
            this.columnFirstName.ReadOnly = true;
            // 
            // columnLastName
            // 
            this.columnLastName.FillWeight = 48.43219F;
            this.columnLastName.HeaderText = "Last Name";
            this.columnLastName.Name = "columnLastName";
            this.columnLastName.ReadOnly = true;
            // 
            // columnProducts
            // 
            this.columnProducts.FillWeight = 48.43219F;
            this.columnProducts.HeaderText = "Products";
            this.columnProducts.Name = "columnProducts";
            this.columnProducts.ReadOnly = true;
            // 
            // columnTotalPrice
            // 
            this.columnTotalPrice.FillWeight = 20F;
            this.columnTotalPrice.HeaderText = "Total Price";
            this.columnTotalPrice.Name = "columnTotalPrice";
            this.columnTotalPrice.ReadOnly = true;
            // 
            // columnButton
            // 
            this.columnButton.FillWeight = 30F;
            this.columnButton.HeaderText = "";
            this.columnButton.Name = "columnButton";
            this.columnButton.ReadOnly = true;
            this.columnButton.Text = "Complete";
            this.columnButton.UseColumnTextForButtonValue = true;
            // 
            // tabControlEmployeeLobby
            // 
            this.tabControlEmployeeLobby.Controls.Add(this.viewOrders);
            this.tabControlEmployeeLobby.Controls.Add(this.viewIngredients);
            this.tabControlEmployeeLobby.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlEmployeeLobby.Location = new System.Drawing.Point(0, 0);
            this.tabControlEmployeeLobby.Name = "tabControlEmployeeLobby";
            this.tabControlEmployeeLobby.SelectedIndex = 0;
            this.tabControlEmployeeLobby.Size = new System.Drawing.Size(585, 366);
            this.tabControlEmployeeLobby.TabIndex = 1;
            // 
            // viewOrders
            // 
            this.viewOrders.Controls.Add(this.btnRefresh);
            this.viewOrders.Controls.Add(this.dataGridViewOrders);
            this.viewOrders.Location = new System.Drawing.Point(4, 22);
            this.viewOrders.Name = "viewOrders";
            this.viewOrders.Padding = new System.Windows.Forms.Padding(3);
            this.viewOrders.Size = new System.Drawing.Size(577, 340);
            this.viewOrders.TabIndex = 0;
            this.viewOrders.Text = "Orders";
            this.viewOrders.UseVisualStyleBackColor = true;
            this.viewOrders.Enter += new System.EventHandler(this.viewOrders_Enter);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(494, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(77, 29);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // viewIngredients
            // 
            this.viewIngredients.Controls.Add(this.comboBoxRestock);
            this.viewIngredients.Controls.Add(this.btnRestock);
            this.viewIngredients.Controls.Add(this.listViewIngredients);
            this.viewIngredients.Location = new System.Drawing.Point(4, 22);
            this.viewIngredients.Name = "viewIngredients";
            this.viewIngredients.Padding = new System.Windows.Forms.Padding(3);
            this.viewIngredients.Size = new System.Drawing.Size(577, 340);
            this.viewIngredients.TabIndex = 1;
            this.viewIngredients.Text = "Ingredients";
            this.viewIngredients.UseVisualStyleBackColor = true;
            this.viewIngredients.Enter += new System.EventHandler(this.viewIngredients_Enter);
            // 
            // comboBoxRestock
            // 
            this.comboBoxRestock.FormattingEnabled = true;
            this.comboBoxRestock.Location = new System.Drawing.Point(298, 9);
            this.comboBoxRestock.MaxDropDownItems = 30;
            this.comboBoxRestock.Name = "comboBoxRestock";
            this.comboBoxRestock.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRestock.TabIndex = 2;
            this.comboBoxRestock.Text = "Select Ingredient";
            // 
            // btnRestock
            // 
            this.btnRestock.Location = new System.Drawing.Point(424, 6);
            this.btnRestock.Name = "btnRestock";
            this.btnRestock.Size = new System.Drawing.Size(75, 28);
            this.btnRestock.TabIndex = 1;
            this.btnRestock.Text = "Restock";
            this.btnRestock.UseVisualStyleBackColor = true;
            this.btnRestock.Click += new System.EventHandler(this.btnRestock_Click);
            // 
            // listViewIngredients
            // 
            this.listViewIngredients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIngredientName,
            this.columnQuantity});
            this.listViewIngredients.GridLines = true;
            this.listViewIngredients.HideSelection = false;
            this.listViewIngredients.Location = new System.Drawing.Point(0, 40);
            this.listViewIngredients.Name = "listViewIngredients";
            this.listViewIngredients.Size = new System.Drawing.Size(577, 304);
            this.listViewIngredients.TabIndex = 0;
            this.listViewIngredients.UseCompatibleStateImageBehavior = false;
            this.listViewIngredients.View = System.Windows.Forms.View.Details;
            // 
            // columnIngredientName
            // 
            this.columnIngredientName.Text = "Name";
            this.columnIngredientName.Width = 252;
            // 
            // columnQuantity
            // 
            this.columnQuantity.Text = "Quantity";
            this.columnQuantity.Width = 143;
            // 
            // EmployeeLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 366);
            this.Controls.Add(this.tabControlEmployeeLobby);
            this.Name = "EmployeeLobby";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeLobby";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeLobby_FormClosed);
            this.Load += new System.EventHandler(this.EmployeeLobby_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.tabControlEmployeeLobby.ResumeLayout(false);
            this.viewOrders.ResumeLayout(false);
            this.viewIngredients.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.TabControl tabControlEmployeeLobby;
        private System.Windows.Forms.TabPage viewOrders;
        private System.Windows.Forms.TabPage viewIngredients;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTotalPrice;
        private System.Windows.Forms.DataGridViewButtonColumn columnButton;
        private System.Windows.Forms.Button btnRestock;
        private System.Windows.Forms.ListView listViewIngredients;
        private System.Windows.Forms.ColumnHeader columnIngredientName;
        private System.Windows.Forms.ColumnHeader columnQuantity;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox comboBoxRestock;
    }
}