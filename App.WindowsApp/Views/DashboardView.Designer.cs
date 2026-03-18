using System.Windows.Forms;

namespace App.WindowsApp.Views
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
            tblDashboard = new TableLayoutPanel();
            flpKpi = new FlowLayoutPanel();
            pnlSales = new Panel();
            lblSalesV = new Label();
            lblSalesT = new Label();
            pnlOrders = new Panel();
            lblOrdersV = new Label();
            lblOrdersT = new Label();
            pnlRevenue = new Panel();
            lblRevenueV = new Label();
            lblRevenueT = new Label();
            pnlLowStock = new Panel();
            lblLowStock = new Label();
            lvlowStock = new ListView();
            colProduct = new ColumnHeader();
            colStock = new ColumnHeader();
            pnlRecentOrders = new Panel();
            lblRecentOrder = new Label();
            lvRecentOrder = new ListView();
            colOrder = new ColumnHeader();
            colCustomer = new ColumnHeader();
            colTotal = new ColumnHeader();
            colStatus = new ColumnHeader();
            tblDashboard.SuspendLayout();
            flpKpi.SuspendLayout();
            pnlSales.SuspendLayout();
            pnlOrders.SuspendLayout();
            pnlRevenue.SuspendLayout();
            pnlLowStock.SuspendLayout();
            pnlRecentOrders.SuspendLayout();
            SuspendLayout();
            // 
            // tblDashboard
            // 
            tblDashboard.ColumnCount = 1;
            tblDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblDashboard.Controls.Add(flpKpi, 0, 0);
            tblDashboard.Controls.Add(pnlLowStock, 0, 1);
            tblDashboard.Controls.Add(pnlRecentOrders, 0, 2);
            tblDashboard.Dock = DockStyle.Fill;
            tblDashboard.Location = new Point(0, 0);
            tblDashboard.Margin = new Padding(3, 4, 3, 4);
            tblDashboard.Name = "tblDashboard";
            tblDashboard.RowCount = 3;
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDashboard.Size = new Size(1087, 821);
            tblDashboard.TabIndex = 0;
            // 
            // flpKpi
            // 
            flpKpi.Controls.Add(pnlSales);
            flpKpi.Controls.Add(pnlOrders);
            flpKpi.Controls.Add(pnlRevenue);
            flpKpi.Dock = DockStyle.Fill;
            flpKpi.Location = new Point(3, 4);
            flpKpi.Margin = new Padding(3, 4, 3, 4);
            flpKpi.Name = "flpKpi";
            flpKpi.Size = new Size(1081, 142);
            flpKpi.TabIndex = 0;
            // 
            // pnlSales
            // 
            pnlSales.BackColor = Color.White;
            pnlSales.Controls.Add(lblSalesV);
            pnlSales.Controls.Add(lblSalesT);
            pnlSales.Dock = DockStyle.Fill;
            pnlSales.Location = new Point(3, 4);
            pnlSales.Margin = new Padding(3, 4, 3, 4);
            pnlSales.Name = "pnlSales";
            pnlSales.Size = new Size(222, 125);
            pnlSales.TabIndex = 0;
            // 
            // lblSalesV
            // 
            lblSalesV.AutoSize = true;
            lblSalesV.Location = new Point(124, 35);
            lblSalesV.Name = "lblSalesV";
            lblSalesV.Size = new Size(42, 25);
            lblSalesV.TabIndex = 1;
            lblSalesV.Text = "100";
            // 
            // lblSalesT
            // 
            lblSalesT.AutoSize = true;
            lblSalesT.Location = new Point(18, 35);
            lblSalesT.Name = "lblSalesT";
            lblSalesT.Size = new Size(52, 25);
            lblSalesT.TabIndex = 0;
            lblSalesT.Text = "Sales";
            // 
            // pnlOrders
            // 
            pnlOrders.BackColor = Color.White;
            pnlOrders.Controls.Add(lblOrdersV);
            pnlOrders.Controls.Add(lblOrdersT);
            pnlOrders.Dock = DockStyle.Fill;
            pnlOrders.Location = new Point(231, 4);
            pnlOrders.Margin = new Padding(3, 4, 3, 4);
            pnlOrders.Name = "pnlOrders";
            pnlOrders.Size = new Size(222, 125);
            pnlOrders.TabIndex = 1;
            // 
            // lblOrdersV
            // 
            lblOrdersV.AutoSize = true;
            lblOrdersV.Location = new Point(92, 35);
            lblOrdersV.Name = "lblOrdersV";
            lblOrdersV.Size = new Size(32, 25);
            lblOrdersV.TabIndex = 1;
            lblOrdersV.Text = "50";
            // 
            // lblOrdersT
            // 
            lblOrdersT.AutoSize = true;
            lblOrdersT.Location = new Point(22, 35);
            lblOrdersT.Name = "lblOrdersT";
            lblOrdersT.Size = new Size(66, 25);
            lblOrdersT.TabIndex = 0;
            lblOrdersT.Text = "Orders";
            lblOrdersT.Click += lblOrdersT_Click;
            // 
            // pnlRevenue
            // 
            pnlRevenue.BackColor = SystemColors.ControlLightLight;
            pnlRevenue.Controls.Add(lblRevenueV);
            pnlRevenue.Controls.Add(lblRevenueT);
            pnlRevenue.Location = new Point(459, 4);
            pnlRevenue.Margin = new Padding(3, 4, 3, 4);
            pnlRevenue.Name = "pnlRevenue";
            pnlRevenue.Size = new Size(222, 125);
            pnlRevenue.TabIndex = 2;
            // 
            // lblRevenueV
            // 
            lblRevenueV.AutoSize = true;
            lblRevenueV.Location = new Point(131, 35);
            lblRevenueV.Name = "lblRevenueV";
            lblRevenueV.Size = new Size(52, 25);
            lblRevenueV.TabIndex = 1;
            lblRevenueV.Text = "1200";
            // 
            // lblRevenueT
            // 
            lblRevenueT.AutoSize = true;
            lblRevenueT.Location = new Point(33, 35);
            lblRevenueT.Name = "lblRevenueT";
            lblRevenueT.Size = new Size(78, 25);
            lblRevenueT.TabIndex = 0;
            lblRevenueT.Text = "Revenue";
            // 
            // pnlLowStock
            // 
            pnlLowStock.Controls.Add(lblLowStock);
            pnlLowStock.Controls.Add(lvlowStock);
            pnlLowStock.Location = new Point(3, 154);
            pnlLowStock.Margin = new Padding(3, 4, 3, 4);
            pnlLowStock.Name = "pnlLowStock";
            pnlLowStock.Size = new Size(1080, 315);
            pnlLowStock.TabIndex = 1;
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Location = new Point(3, 22);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(92, 25);
            lblLowStock.TabIndex = 1;
            lblLowStock.Text = "Low Stock";
            lblLowStock.Click += lblLowStock_Click;
            // 
            // lvlowStock
            // 
            lvlowStock.BackColor = Color.White;
            lvlowStock.BorderStyle = BorderStyle.FixedSingle;
            lvlowStock.Columns.AddRange(new ColumnHeader[] { colProduct, colStock });
            lvlowStock.FullRowSelect = true;
            lvlowStock.GridLines = true;
            lvlowStock.Location = new Point(3, 51);
            lvlowStock.Margin = new Padding(3, 4, 3, 4);
            lvlowStock.Name = "lvlowStock";
            lvlowStock.Size = new Size(1073, 238);
            lvlowStock.TabIndex = 0;
            lvlowStock.UseCompatibleStateImageBehavior = false;
            lvlowStock.View = View.Details;
            lvlowStock.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // colProduct
            // 
            colProduct.Text = "Product";
            // 
            // colStock
            // 
            colStock.Text = "Stock";
            // 
            // pnlRecentOrders
            // 
            pnlRecentOrders.Controls.Add(lblRecentOrder);
            pnlRecentOrders.Controls.Add(lvRecentOrder);
            pnlRecentOrders.Location = new Point(3, 489);
            pnlRecentOrders.Margin = new Padding(3, 4, 3, 4);
            pnlRecentOrders.Name = "pnlRecentOrders";
            pnlRecentOrders.Size = new Size(1080, 289);
            pnlRecentOrders.TabIndex = 2;
            pnlRecentOrders.Paint += pnlRecentOrders_Paint;
            // 
            // lblRecentOrder
            // 
            lblRecentOrder.AutoSize = true;
            lblRecentOrder.Location = new Point(3, 20);
            lblRecentOrder.Name = "lblRecentOrder";
            lblRecentOrder.Size = new Size(115, 25);
            lblRecentOrder.TabIndex = 2;
            lblRecentOrder.Text = "Recent Order";
            // 
            // lvRecentOrder
            // 
            lvRecentOrder.BackColor = Color.White;
            lvRecentOrder.BorderStyle = BorderStyle.FixedSingle;
            lvRecentOrder.Columns.AddRange(new ColumnHeader[] { colOrder, colCustomer, colTotal, colStatus });
            lvRecentOrder.FullRowSelect = true;
            lvRecentOrder.GridLines = true;
            lvRecentOrder.Location = new Point(8, 62);
            lvRecentOrder.Margin = new Padding(3, 4, 3, 4);
            lvRecentOrder.Name = "lvRecentOrder";
            lvRecentOrder.Size = new Size(1069, 222);
            lvRecentOrder.TabIndex = 0;
            lvRecentOrder.UseCompatibleStateImageBehavior = false;
            lvRecentOrder.View = View.Details;
            // 
            // colOrder
            // 
            colOrder.Text = "Order";
            // 
            // colCustomer
            // 
            colCustomer.Text = "Customer";
            // 
            // colTotal
            // 
            colTotal.Text = "Total";
            // 
            // colStatus
            // 
            colStatus.Text = "Status";
            // 
            // DashboardView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblDashboard);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DashboardView";
            Size = new Size(1087, 821);
            tblDashboard.ResumeLayout(false);
            flpKpi.ResumeLayout(false);
            pnlSales.ResumeLayout(false);
            pnlSales.PerformLayout();
            pnlOrders.ResumeLayout(false);
            pnlOrders.PerformLayout();
            pnlRevenue.ResumeLayout(false);
            pnlRevenue.PerformLayout();
            pnlLowStock.ResumeLayout(false);
            pnlLowStock.PerformLayout();
            pnlRecentOrders.ResumeLayout(false);
            pnlRecentOrders.PerformLayout();
            ResumeLayout(false);

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
