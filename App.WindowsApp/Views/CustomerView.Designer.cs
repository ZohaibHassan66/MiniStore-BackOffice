namespace App.WindowsApp.Views
{
    partial class CustomerView
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tsCommands = new ToolStrip();
            tsbAdd = new ToolStripButton();
            tsbEdit = new ToolStripButton();
            tsbView = new ToolStripButton();
            tsbDelete = new ToolStripButton();
            tsSeprator = new ToolStripSeparator();
            tsbRefresh = new ToolStripButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblCount = new Label();
            pnlCustomersData = new Panel();
            dgvCustomers = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colAddress = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            tsCommands.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            pnlCustomersData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tsCommands, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Controls.Add(pnlCustomersData, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.602151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.602151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 82.7957F));
            tableLayoutPanel1.Size = new Size(775, 520);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tsCommands
            // 
            tsCommands.BackColor = Color.White;
            tsCommands.ImageScalingSize = new Size(24, 24);
            tsCommands.Items.AddRange(new ToolStripItem[] { tsbAdd, tsbEdit, tsbView, tsbDelete, tsSeprator, tsbRefresh });
            tsCommands.Location = new Point(0, 0);
            tsCommands.Name = "tsCommands";
            tsCommands.Size = new Size(775, 34);
            tsCommands.TabIndex = 0;
            tsCommands.Text = "toolStrip1";
            tsCommands.ItemClicked += tsCommands_ItemClicked;
            // 
            // tsbAdd
            // 
            tsbAdd.Image = Properties.Resources.Add;
            tsbAdd.ImageTransparentColor = Color.Magenta;
            tsbAdd.Name = "tsbAdd";
            tsbAdd.Size = new Size(74, 29);
            tsbAdd.Text = "Add";
            tsbAdd.Click += tsbAdd_Click;
            // 
            // tsbEdit
            // 
            tsbEdit.Image = Properties.Resources.edit;
            tsbEdit.ImageTransparentColor = Color.Magenta;
            tsbEdit.Name = "tsbEdit";
            tsbEdit.Size = new Size(70, 29);
            tsbEdit.Text = "Edit";
            tsbEdit.Click += tsbEdit_Click;
            // 
            // tsbView
            // 
            tsbView.Image = Properties.Resources.eye_search;
            tsbView.ImageTransparentColor = Color.Magenta;
            tsbView.Name = "tsbView";
            tsbView.Size = new Size(77, 29);
            tsbView.Text = "View";
            tsbView.Click += tsbView_Click;
            // 
            // tsbDelete
            // 
            tsbDelete.Image = Properties.Resources.delete;
            tsbDelete.ImageTransparentColor = Color.Magenta;
            tsbDelete.Name = "tsbDelete";
            tsbDelete.Size = new Size(90, 29);
            tsbDelete.Text = "Delete";
            tsbDelete.Click += tsbDelete_Click;
            // 
            // tsSeprator
            // 
            tsSeprator.Name = "tsSeprator";
            tsSeprator.Size = new Size(6, 34);
            // 
            // tsbRefresh
            // 
            tsbRefresh.Image = Properties.Resources.refresh;
            tsbRefresh.ImageTransparentColor = Color.Magenta;
            tsbRefresh.Name = "tsbRefresh";
            tsbRefresh.Size = new Size(98, 29);
            tsbRefresh.Text = "Refresh";
            tsbRefresh.Click += tsbRefresh_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(lblSearch);
            flowLayoutPanel1.Controls.Add(txtSearch);
            flowLayoutPanel1.Controls.Add(lblCount);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 47);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(769, 38);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F);
            lblSearch.Location = new Point(3, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(70, 28);
            lblSearch.TabIndex = 3;
            lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(79, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(456, 34);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 10F);
            lblCount.Location = new Point(541, 0);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(85, 28);
            lblCount.TabIndex = 5;
            lblCount.Text = "Count: 0";
            // 
            // pnlCustomersData
            // 
            pnlCustomersData.Controls.Add(dgvCustomers);
            pnlCustomersData.Dock = DockStyle.Fill;
            pnlCustomersData.Location = new Point(3, 91);
            pnlCustomersData.Name = "pnlCustomersData";
            pnlCustomersData.Size = new Size(769, 426);
            pnlCustomersData.TabIndex = 2;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.BackgroundColor = Color.White;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colPhone, colEmail, colAddress });
            dgvCustomers.Dock = DockStyle.Fill;
            dgvCustomers.Location = new Point(0, 0);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersWidth = 62;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(769, 426);
            dgvCustomers.TabIndex = 0;
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
            // colPhone
            // 
            colPhone.DataPropertyName = "Phone";
            colPhone.HeaderText = "Phone";
            colPhone.MinimumWidth = 8;
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.DataPropertyName = "Email";
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 8;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // colAddress
            // 
            colAddress.DataPropertyName = "Address";
            colAddress.HeaderText = "Address";
            colAddress.MinimumWidth = 8;
            colAddress.Name = "colAddress";
            colAddress.ReadOnly = true;
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "CustomerView";
            Size = new Size(775, 520);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tsCommands.ResumeLayout(false);
            tsCommands.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            pnlCustomersData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ToolStrip tsCommands;
        private ToolStripButton tsbAdd;
        private ToolStripButton tsbEdit;
        private ToolStripButton tsbView;
        private ToolStripButton tsbDelete;
        private ToolStripSeparator tsSeprator;
        private ToolStripButton tsbRefresh;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblCount;
        private Panel pnlCustomersData;
        private DataGridView dgvCustomers;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colAddress;
    }
}
