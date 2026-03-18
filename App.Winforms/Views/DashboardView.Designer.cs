namespace App.Winforms.Views
{
    partial class DashboardView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblDashboard = new System.Windows.Forms.TableLayoutPanel();
            this.flpKpi = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSales = new System.Windows.Forms.Panel();
            this.lblSalesV = new System.Windows.Forms.Label();
            this.lblSalesT = new System.Windows.Forms.Label();
            this.pnlOrders = new System.Windows.Forms.Panel();
            this.lblOrdersV = new System.Windows.Forms.Label();
            this.lblOrdersT = new System.Windows.Forms.Label();
            this.pnlRevenue = new System.Windows.Forms.Panel();
            this.lblRevenueV = new System.Windows.Forms.Label();
            this.lblRevenueT = new System.Windows.Forms.Label();
            this.pnlLowStock = new System.Windows.Forms.Panel();
            this.pnlOrder = new System.Windows.Forms.FlowLayoutPanel();
            this.lblLowStock = new System.Windows.Forms.Label();
            this.lvlowStock = new System.Windows.Forms.ListView();
            this.colProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlRecentOrders = new System.Windows.Forms.Panel();
            this.lblRecentOrder = new System.Windows.Forms.Label();
            this.lvRecentOrder = new System.Windows.Forms.ListView();
            this.colOrder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCustomer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tblDashboard.SuspendLayout();
            this.flpKpi.SuspendLayout();
            this.pnlSales.SuspendLayout();
            this.pnlOrders.SuspendLayout();
            this.pnlRevenue.SuspendLayout();
            this.pnlLowStock.SuspendLayout();
            this.pnlRecentOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblDashboard
            // 
            this.tblDashboard.ColumnCount = 1;
            this.tblDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDashboard.Controls.Add(this.flpKpi, 0, 0);
            this.tblDashboard.Controls.Add(this.pnlLowStock, 0, 1);
            this.tblDashboard.Controls.Add(this.pnlRecentOrders, 0, 2);
            this.tblDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDashboard.Location = new System.Drawing.Point(0, 0);
            this.tblDashboard.Name = "tblDashboard";
            this.tblDashboard.RowCount = 3;
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDashboard.Size = new System.Drawing.Size(978, 657);
            this.tblDashboard.TabIndex = 0;
            // 
            // flpKpi
            // 
            this.flpKpi.Controls.Add(this.pnlSales);
            this.flpKpi.Controls.Add(this.pnlOrders);
            this.flpKpi.Controls.Add(this.pnlRevenue);
            this.flpKpi.Location = new System.Drawing.Point(3, 3);
            this.flpKpi.Name = "flpKpi";
            this.flpKpi.Size = new System.Drawing.Size(972, 114);
            this.flpKpi.TabIndex = 0;
            // 
            // pnlSales
            // 
            this.pnlSales.BackColor = System.Drawing.Color.White;
            this.pnlSales.Controls.Add(this.lblSalesV);
            this.pnlSales.Controls.Add(this.lblSalesT);
            this.pnlSales.Location = new System.Drawing.Point(3, 3);
            this.pnlSales.Name = "pnlSales";
            this.pnlSales.Size = new System.Drawing.Size(200, 100);
            this.pnlSales.TabIndex = 0;
            // 
            // lblSalesV
            // 
            this.lblSalesV.AutoSize = true;
            this.lblSalesV.Location = new System.Drawing.Point(112, 28);
            this.lblSalesV.Name = "lblSalesV";
            this.lblSalesV.Size = new System.Drawing.Size(36, 20);
            this.lblSalesV.TabIndex = 1;
            this.lblSalesV.Text = "100";
            // 
            // lblSalesT
            // 
            this.lblSalesT.AutoSize = true;
            this.lblSalesT.Location = new System.Drawing.Point(16, 28);
            this.lblSalesT.Name = "lblSalesT";
            this.lblSalesT.Size = new System.Drawing.Size(49, 20);
            this.lblSalesT.TabIndex = 0;
            this.lblSalesT.Text = "Sales";
            // 
            // pnlOrders
            // 
            this.pnlOrders.BackColor = System.Drawing.Color.White;
            this.pnlOrders.Controls.Add(this.lblOrdersV);
            this.pnlOrders.Controls.Add(this.lblOrdersT);
            this.pnlOrders.Location = new System.Drawing.Point(209, 3);
            this.pnlOrders.Name = "pnlOrders";
            this.pnlOrders.Size = new System.Drawing.Size(200, 100);
            this.pnlOrders.TabIndex = 1;
            // 
            // lblOrdersV
            // 
            this.lblOrdersV.AutoSize = true;
            this.lblOrdersV.Location = new System.Drawing.Point(83, 28);
            this.lblOrdersV.Name = "lblOrdersV";
            this.lblOrdersV.Size = new System.Drawing.Size(27, 20);
            this.lblOrdersV.TabIndex = 1;
            this.lblOrdersV.Text = "50";
            // 
            // lblOrdersT
            // 
            this.lblOrdersT.AutoSize = true;
            this.lblOrdersT.Location = new System.Drawing.Point(20, 28);
            this.lblOrdersT.Name = "lblOrdersT";
            this.lblOrdersT.Size = new System.Drawing.Size(57, 20);
            this.lblOrdersT.TabIndex = 0;
            this.lblOrdersT.Text = "Orders";
            this.lblOrdersT.Click += new System.EventHandler(this.lblOrdersT_Click);
            // 
            // pnlRevenue
            // 
            this.pnlRevenue.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlRevenue.Controls.Add(this.lblRevenueV);
            this.pnlRevenue.Controls.Add(this.lblRevenueT);
            this.pnlRevenue.Location = new System.Drawing.Point(415, 3);
            this.pnlRevenue.Name = "pnlRevenue";
            this.pnlRevenue.Size = new System.Drawing.Size(200, 100);
            this.pnlRevenue.TabIndex = 2;
            // 
            // lblRevenueV
            // 
            this.lblRevenueV.AutoSize = true;
            this.lblRevenueV.Location = new System.Drawing.Point(118, 28);
            this.lblRevenueV.Name = "lblRevenueV";
            this.lblRevenueV.Size = new System.Drawing.Size(45, 20);
            this.lblRevenueV.TabIndex = 1;
            this.lblRevenueV.Text = "1200";
            // 
            // lblRevenueT
            // 
            this.lblRevenueT.AutoSize = true;
            this.lblRevenueT.Location = new System.Drawing.Point(30, 28);
            this.lblRevenueT.Name = "lblRevenueT";
            this.lblRevenueT.Size = new System.Drawing.Size(73, 20);
            this.lblRevenueT.TabIndex = 0;
            this.lblRevenueT.Text = "Revenue";
            // 
            // pnlLowStock
            // 
            this.pnlLowStock.Controls.Add(this.lblLowStock);
            this.pnlLowStock.Controls.Add(this.lvlowStock);
            this.pnlLowStock.Controls.Add(this.pnlOrder);
            this.pnlLowStock.Location = new System.Drawing.Point(3, 123);
            this.pnlLowStock.Name = "pnlLowStock";
            this.pnlLowStock.Size = new System.Drawing.Size(972, 252);
            this.pnlLowStock.TabIndex = 1;
            // 
            // pnlOrder
            // 
            this.pnlOrder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlOrder.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlOrder.Location = new System.Drawing.Point(713, 18);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(200, 100);
            this.pnlOrder.TabIndex = 0;
            // 
            // lblLowStock
            // 
            this.lblLowStock.AutoSize = true;
            this.lblLowStock.Location = new System.Drawing.Point(3, 18);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(83, 20);
            this.lblLowStock.TabIndex = 1;
            this.lblLowStock.Text = "Low Stock";
            this.lblLowStock.Click += new System.EventHandler(this.lblLowStock_Click);
            // 
            // lvlowStock
            // 
            this.lvlowStock.BackColor = System.Drawing.Color.White;
            this.lvlowStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvlowStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProduct,
            this.colStock});
            this.lvlowStock.FullRowSelect = true;
            this.lvlowStock.GridLines = true;
            this.lvlowStock.HideSelection = false;
            this.lvlowStock.Location = new System.Drawing.Point(3, 41);
            this.lvlowStock.Name = "lvlowStock";
            this.lvlowStock.Size = new System.Drawing.Size(966, 191);
            this.lvlowStock.TabIndex = 0;
            this.lvlowStock.UseCompatibleStateImageBehavior = false;
            this.lvlowStock.View = System.Windows.Forms.View.Details;
            this.lvlowStock.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // colProduct
            // 
            this.colProduct.Text = "Product";
            // 
            // colStock
            // 
            this.colStock.Text = "Stock";
            // 
            // pnlRecentOrders
            // 
            this.pnlRecentOrders.Controls.Add(this.lblRecentOrder);
            this.pnlRecentOrders.Controls.Add(this.lvRecentOrder);
            this.pnlRecentOrders.Location = new System.Drawing.Point(3, 391);
            this.pnlRecentOrders.Name = "pnlRecentOrders";
            this.pnlRecentOrders.Size = new System.Drawing.Size(972, 231);
            this.pnlRecentOrders.TabIndex = 2;
            this.pnlRecentOrders.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRecentOrders_Paint);
            // 
            // lblRecentOrder
            // 
            this.lblRecentOrder.AutoSize = true;
            this.lblRecentOrder.Location = new System.Drawing.Point(3, 16);
            this.lblRecentOrder.Name = "lblRecentOrder";
            this.lblRecentOrder.Size = new System.Drawing.Size(105, 20);
            this.lblRecentOrder.TabIndex = 2;
            this.lblRecentOrder.Text = "Recent Order";
            // 
            // lvRecentOrder
            // 
            this.lvRecentOrder.BackColor = System.Drawing.Color.White;
            this.lvRecentOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvRecentOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colOrder,
            this.colCustomer,
            this.colTotal,
            this.colStatus});
            this.lvRecentOrder.FullRowSelect = true;
            this.lvRecentOrder.GridLines = true;
            this.lvRecentOrder.HideSelection = false;
            this.lvRecentOrder.Location = new System.Drawing.Point(7, 50);
            this.lvRecentOrder.Name = "lvRecentOrder";
            this.lvRecentOrder.Size = new System.Drawing.Size(962, 178);
            this.lvRecentOrder.TabIndex = 0;
            this.lvRecentOrder.UseCompatibleStateImageBehavior = false;
            this.lvRecentOrder.View = System.Windows.Forms.View.Details;
            // 
            // colOrder
            // 
            this.colOrder.Text = "Order";
            // 
            // colCustomer
            // 
            this.colCustomer.Text = "Customer";
            // 
            // colTotal
            // 
            this.colTotal.Text = "Total";
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblDashboard);
            this.Name = "DashboardView";
            this.Size = new System.Drawing.Size(978, 657);
            this.tblDashboard.ResumeLayout(false);
            this.flpKpi.ResumeLayout(false);
            this.pnlSales.ResumeLayout(false);
            this.pnlSales.PerformLayout();
            this.pnlOrders.ResumeLayout(false);
            this.pnlOrders.PerformLayout();
            this.pnlRevenue.ResumeLayout(false);
            this.pnlRevenue.PerformLayout();
            this.pnlLowStock.ResumeLayout(false);
            this.pnlLowStock.PerformLayout();
            this.pnlRecentOrders.ResumeLayout(false);
            this.pnlRecentOrders.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblDashboard;
        private System.Windows.Forms.FlowLayoutPanel flpKpi;
        private System.Windows.Forms.Panel pnlSales;
        private System.Windows.Forms.Panel pnlOrders;
        private System.Windows.Forms.Label lblSalesV;
        private System.Windows.Forms.Label lblSalesT;
        private System.Windows.Forms.FlowLayoutPanel pnlOrder;
        private System.Windows.Forms.Label lblOrdersT;
        private System.Windows.Forms.Panel pnlRevenue;
        private System.Windows.Forms.Label lblOrdersV;
        private System.Windows.Forms.Label lblRevenueV;
        private System.Windows.Forms.Label lblRevenueT;
        private System.Windows.Forms.Panel pnlLowStock;
        private System.Windows.Forms.Panel pnlRecentOrders;
        private System.Windows.Forms.Label lblLowStock;
        private System.Windows.Forms.ListView lvlowStock;
        private System.Windows.Forms.ColumnHeader colProduct;
        private System.Windows.Forms.ColumnHeader colStock;
        private System.Windows.Forms.Label lblRecentOrder;
        private System.Windows.Forms.ListView lvRecentOrder;
        private System.Windows.Forms.ColumnHeader colOrder;
        private System.Windows.Forms.ColumnHeader colCustomer;
        private System.Windows.Forms.ColumnHeader colTotal;
        private System.Windows.Forms.ColumnHeader colStatus;
    }
}
