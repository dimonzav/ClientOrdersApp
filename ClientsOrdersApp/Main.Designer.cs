namespace ClientsOrdersApp
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lbClients = new System.Windows.Forms.ListBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.orderBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btnOrderStatus = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.labelClienName = new System.Windows.Forms.Label();
            this.orderBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddClient = new System.Windows.Forms.Button();
            this.orderBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.orderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clients";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1026, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClientToolStripMenuItem,
            this.exportToExcelToolStripMenuItem,
            this.editProductsToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addClientToolStripMenuItem
            // 
            this.addClientToolStripMenuItem.Name = "addClientToolStripMenuItem";
            this.addClientToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.addClientToolStripMenuItem.Text = "Add client";
            // 
            // exportToExcelToolStripMenuItem
            // 
            this.exportToExcelToolStripMenuItem.Name = "exportToExcelToolStripMenuItem";
            this.exportToExcelToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.exportToExcelToolStripMenuItem.Text = "Export to excel";
            this.exportToExcelToolStripMenuItem.Click += new System.EventHandler(this.exportToExcelToolStripMenuItem_Click);
            // 
            // editProductsToolStripMenuItem
            // 
            this.editProductsToolStripMenuItem.Name = "editProductsToolStripMenuItem";
            this.editProductsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.editProductsToolStripMenuItem.Text = "Edit products";
            this.editProductsToolStripMenuItem.Click += new System.EventHandler(this.editProductsToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // lbClients
            // 
            this.lbClients.DataSource = this.clientBindingSource;
            this.lbClients.DisplayMember = "Name";
            this.lbClients.FormattingEnabled = true;
            this.lbClients.Location = new System.Drawing.Point(9, 73);
            this.lbClients.Name = "lbClients";
            this.lbClients.Size = new System.Drawing.Size(120, 316);
            this.lbClients.TabIndex = 2;
            this.lbClients.ValueMember = "ClientId";
            this.lbClients.SelectedIndexChanged += new System.EventHandler(this.lbClients_SelectedIndexChanged);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(ClientsOrdersApp.Models.Client);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvOrders);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnOrderStatus);
            this.panel1.Controls.Add(this.btnAddOrder);
            this.panel1.Controls.Add(this.btnEditClient);
            this.panel1.Controls.Add(this.labelClienName);
            this.panel1.Location = new System.Drawing.Point(138, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 566);
            this.panel1.TabIndex = 3;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AutoGenerateColumns = false;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNumberDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.createdDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgvOrders.DataSource = this.orderBindingSource6;
            this.dgvOrders.Location = new System.Drawing.Point(24, 125);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.Size = new System.Drawing.Size(854, 334);
            this.dgvOrders.TabIndex = 5;
            // 
            // orderBindingSource5
            // 
            this.orderBindingSource5.DataSource = typeof(ClientsOrdersApp.Models.Order);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Orders";
            // 
            // btnOrderStatus
            // 
            this.btnOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOrderStatus.Location = new System.Drawing.Point(728, 11);
            this.btnOrderStatus.Name = "btnOrderStatus";
            this.btnOrderStatus.Size = new System.Drawing.Size(150, 39);
            this.btnOrderStatus.TabIndex = 3;
            this.btnOrderStatus.Text = "Set order status";
            this.btnOrderStatus.UseVisualStyleBackColor = true;
            this.btnOrderStatus.Click += new System.EventHandler(this.btnOrderStatus_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddOrder.Location = new System.Drawing.Point(567, 11);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(125, 39);
            this.btnAddOrder.TabIndex = 2;
            this.btnAddOrder.Text = "Add order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnEditClient
            // 
            this.btnEditClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditClient.Location = new System.Drawing.Point(402, 13);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(118, 37);
            this.btnEditClient.TabIndex = 1;
            this.btnEditClient.Text = "Edit client";
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // labelClienName
            // 
            this.labelClienName.AutoSize = true;
            this.labelClienName.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClienName.Location = new System.Drawing.Point(17, 11);
            this.labelClienName.Name = "labelClienName";
            this.labelClienName.Size = new System.Drawing.Size(339, 39);
            this.labelClienName.TabIndex = 0;
            this.labelClienName.Text = "Selected client name";
            // 
            // orderBindingSource3
            // 
            this.orderBindingSource3.DataSource = typeof(ClientsOrdersApp.Models.Order);
            // 
            // clientBindingSource2
            // 
            this.clientBindingSource2.DataSource = typeof(ClientsOrdersApp.Models.Client);
            // 
            // orderBindingSource2
            // 
            this.orderBindingSource2.DataSource = typeof(ClientsOrdersApp.Models.Order);
            // 
            // orderBindingSource1
            // 
            this.orderBindingSource1.DataSource = typeof(ClientsOrdersApp.Models.Order);
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(ClientsOrdersApp.Models.Order);
            // 
            // clientBindingSource1
            // 
            this.clientBindingSource1.DataSource = typeof(ClientsOrdersApp.Models.Client);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddClient.Location = new System.Drawing.Point(12, 418);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(117, 41);
            this.btnAddClient.TabIndex = 4;
            this.btnAddClient.Text = "Add new client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // orderBindingSource4
            // 
            this.orderBindingSource4.DataSource = typeof(ClientsOrdersApp.Models.Order);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(ClientsOrdersApp.ViewModels.ProductViewModel);
            // 
            // orderBindingSource6
            // 
            this.orderBindingSource6.DataSource = typeof(ClientsOrdersApp.Models.Order);
            // 
            // orderNumberDataGridViewTextBoxColumn
            // 
            this.orderNumberDataGridViewTextBoxColumn.DataPropertyName = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.HeaderText = "Id";
            this.orderNumberDataGridViewTextBoxColumn.Name = "orderNumberDataGridViewTextBoxColumn";
            this.orderNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            this.productDataGridViewTextBoxColumn.ReadOnly = true;
            this.productDataGridViewTextBoxColumn.Width = 210;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // createdDataGridViewTextBoxColumn
            // 
            this.createdDataGridViewTextBoxColumn.DataPropertyName = "Created";
            this.createdDataGridViewTextBoxColumn.HeaderText = "Created";
            this.createdDataGridViewTextBoxColumn.Name = "createdDataGridViewTextBoxColumn";
            this.createdDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 175;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 472);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbClients);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientApp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListBox lbClients;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOrderStatus;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Label labelClienName;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.ToolStripMenuItem addClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.BindingSource clientBindingSource1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource orderBindingSource1;
        private System.Windows.Forms.BindingSource orderBindingSource2;
        private System.Windows.Forms.BindingSource clientBindingSource2;
        private System.Windows.Forms.BindingSource orderBindingSource3;
        private System.Windows.Forms.BindingSource orderBindingSource5;
        private System.Windows.Forms.BindingSource orderBindingSource4;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderBindingSource6;
    }
}