namespace App.WindowsApp.Views
{
    partial class ProductView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductView));
            tblProducts = new TableLayoutPanel();
            pnlToolbar = new Panel();
            toolStrip = new ToolStrip();
            tbAdd = new ToolStripButton();
            tbEdit = new ToolStripButton();
            tbView = new ToolStripButton();
            tbDelete = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tbRefresh = new ToolStripButton();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblStock = new Label();
            txtSearch = new TextBox();
            cmdCategory = new ComboBox();
            cmdStock = new ComboBox();
            lblSearch = new Label();
            lblCategory = new Label();
            pnlGrid = new Panel();
            dgvProducts = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            tblProducts.SuspendLayout();
            pnlToolbar.SuspendLayout();
            toolStrip.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // tblProducts
            // 
            tblProducts.ColumnCount = 1;
            tblProducts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblProducts.Controls.Add(pnlToolbar, 0, 0);
            tblProducts.Controls.Add(panel1, 0, 1);
            tblProducts.Controls.Add(pnlGrid, 0, 2);
            tblProducts.Dock = DockStyle.Fill;
            tblProducts.Location = new Point(0, 0);
            tblProducts.Margin = new Padding(3, 4, 3, 4);
            tblProducts.Name = "tblProducts";
            tblProducts.Padding = new Padding(18, 20, 18, 20);
            tblProducts.RowCount = 3;
            tblProducts.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tblProducts.RowStyles.Add(new RowStyle(SizeType.Absolute, 105F));
            tblProducts.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblProducts.Size = new Size(744, 480);
            tblProducts.TabIndex = 0;
            // 
            // pnlToolbar
            // 
            pnlToolbar.Controls.Add(toolStrip);
            pnlToolbar.Dock = DockStyle.Fill;
            pnlToolbar.Location = new Point(21, 24);
            pnlToolbar.Margin = new Padding(3, 4, 3, 4);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Size = new Size(702, 62);
            pnlToolbar.TabIndex = 0;
            // 
            // toolStrip
            // 
            toolStrip.BackColor = Color.White;
            toolStrip.Dock = DockStyle.Fill;
            toolStrip.ImageScalingSize = new Size(24, 24);
            toolStrip.Items.AddRange(new ToolStripItem[] { tbAdd, tbEdit, tbView, tbDelete, toolStripSeparator1, tbRefresh });
            toolStrip.Location = new Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(702, 62);
            toolStrip.TabIndex = 0;
            toolStrip.Text = "toolStrip1";
            // 
            // tbAdd
            // 
            tbAdd.Image = (Image)resources.GetObject("tbAdd.Image");
            tbAdd.ImageTransparentColor = Color.Magenta;
            tbAdd.Name = "tbAdd";
            tbAdd.Size = new Size(74, 57);
            tbAdd.Text = "Add";
            tbAdd.Click += tbAdd_Click;
            // 
            // tbEdit
            // 
            tbEdit.Image = (Image)resources.GetObject("tbEdit.Image");
            tbEdit.ImageTransparentColor = Color.Magenta;
            tbEdit.Name = "tbEdit";
            tbEdit.Size = new Size(70, 57);
            tbEdit.Text = "Edit";
            tbEdit.Click += tbEdit_Click;
            // 
            // tbView
            // 
            tbView.Image = (Image)resources.GetObject("tbView.Image");
            tbView.ImageTransparentColor = Color.Magenta;
            tbView.Name = "tbView";
            tbView.Size = new Size(77, 57);
            tbView.Text = "View";
            tbView.Click += tbView_Click;
            // 
            // tbDelete
            // 
            tbDelete.Image = (Image)resources.GetObject("tbDelete.Image");
            tbDelete.ImageTransparentColor = Color.Magenta;
            tbDelete.Name = "tbDelete";
            tbDelete.Size = new Size(90, 57);
            tbDelete.Text = "Delete";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 62);
            // 
            // tbRefresh
            // 
            tbRefresh.Image = (Image)resources.GetObject("tbRefresh.Image");
            tbRefresh.ImageTransparentColor = Color.Magenta;
            tbRefresh.Name = "tbRefresh";
            tbRefresh.Size = new Size(98, 57);
            tbRefresh.Text = "Refresh";
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(21, 94);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(13, 12, 13, 12);
            panel1.Size = new Size(702, 97);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(lblStock, 2, 0);
            tableLayoutPanel1.Controls.Add(txtSearch, 0, 1);
            tableLayoutPanel1.Controls.Add(cmdCategory, 1, 1);
            tableLayoutPanel1.Controls.Add(cmdStock, 2, 1);
            tableLayoutPanel1.Controls.Add(lblSearch, 0, 0);
            tableLayoutPanel1.Controls.Add(lblCategory, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(13, 12);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(676, 73);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Dock = DockStyle.Fill;
            lblStock.Location = new Point(475, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(198, 36);
            lblStock.TabIndex = 5;
            lblStock.Text = "Stock Status";
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Location = new Point(3, 40);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(264, 31);
            txtSearch.TabIndex = 0;
            // 
            // cmdCategory
            // 
            cmdCategory.Dock = DockStyle.Fill;
            cmdCategory.FormattingEnabled = true;
            cmdCategory.Location = new Point(273, 40);
            cmdCategory.Margin = new Padding(3, 4, 3, 4);
            cmdCategory.Name = "cmdCategory";
            cmdCategory.Size = new Size(196, 33);
            cmdCategory.TabIndex = 1;
            // 
            // cmdStock
            // 
            cmdStock.Dock = DockStyle.Fill;
            cmdStock.FormattingEnabled = true;
            cmdStock.Location = new Point(475, 40);
            cmdStock.Margin = new Padding(3, 4, 3, 4);
            cmdStock.Name = "cmdStock";
            cmdStock.Size = new Size(198, 33);
            cmdStock.TabIndex = 2;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Dock = DockStyle.Fill;
            lblSearch.Location = new Point(3, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(264, 36);
            lblSearch.TabIndex = 3;
            lblSearch.Text = "Search";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Dock = DockStyle.Fill;
            lblCategory.Location = new Point(273, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(196, 36);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "Category";
            // 
            // pnlGrid
            // 
            pnlGrid.BackColor = Color.White;
            pnlGrid.Controls.Add(dgvProducts);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Location = new Point(21, 199);
            pnlGrid.Margin = new Padding(3, 4, 3, 4);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new Padding(13, 15, 13, 15);
            pnlGrid.Size = new Size(702, 257);
            pnlGrid.TabIndex = 2;
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colCategory, colPrice, colStock, colStatus });
            dgvProducts.Location = new Point(13, 15);
            dgvProducts.Margin = new Padding(3, 4, 3, 4);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.RowTemplate.Height = 28;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(672, 224);
            dgvProducts.TabIndex = 0;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.MinimumWidth = 8;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colName
            // 
            colName.DataPropertyName = "Name";
            colName.HeaderText = "Name";
            colName.MinimumWidth = 8;
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colCategory
            // 
            colCategory.DataPropertyName = "Category";
            colCategory.HeaderText = "Category";
            colCategory.MinimumWidth = 8;
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            // 
            // colPrice
            // 
            colPrice.DataPropertyName = "Price";
            colPrice.HeaderText = "Price";
            colPrice.MinimumWidth = 8;
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            // 
            // colStock
            // 
            colStock.DataPropertyName = "Stock";
            colStock.HeaderText = "Stock";
            colStock.MinimumWidth = 8;
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 8;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblProducts);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductView";
            Size = new Size(744, 480);
            Load += ProductView_Load;
            tblProducts.ResumeLayout(false);
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblProducts;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tbAdd;
        private System.Windows.Forms.ToolStripButton tbEdit;
        private System.Windows.Forms.ToolStripButton tbView;
        private System.Windows.Forms.ToolStripButton tbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbRefresh;


        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmdCategory;
        private System.Windows.Forms.ComboBox cmdStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvProducts;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colStock;
        private DataGridViewTextBoxColumn colStatus;
    }
}
