namespace App.WindowsApp.Forms
{
    partial class CustomerForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            txtId = new TextBox();
            lblId = new Label();
            txtAddress = new TextBox();
            lblAddress = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtPhone = new TextBox();
            lblPhone = new Label();
            txtName = new TextBox();
            lblName = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnSave = new Button();
            btnCancel = new Button();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Controls.Add(txtId, 1, 4);
            tableLayoutPanel1.Controls.Add(lblId, 0, 4);
            tableLayoutPanel1.Controls.Add(txtAddress, 1, 3);
            tableLayoutPanel1.Controls.Add(lblAddress, 0, 3);
            tableLayoutPanel1.Controls.Add(txtEmail, 1, 2);
            tableLayoutPanel1.Controls.Add(lblEmail, 0, 2);
            tableLayoutPanel1.Controls.Add(txtPhone, 1, 1);
            tableLayoutPanel1.Controls.Add(lblPhone, 0, 1);
            tableLayoutPanel1.Controls.Add(txtName, 1, 0);
            tableLayoutPanel1.Controls.Add(lblName, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Size = new Size(835, 217);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.Dock = DockStyle.Fill;
            txtId.Location = new Point(128, 180);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(704, 31);
            txtId.TabIndex = 10;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Dock = DockStyle.Fill;
            lblId.Font = new Font("Segoe UI", 9F);
            lblId.Location = new Point(3, 177);
            lblId.Name = "lblId";
            lblId.Size = new Size(119, 40);
            lblId.TabIndex = 9;
            lblId.Text = "Id";
            // 
            // txtAddress
            // 
            txtAddress.Dock = DockStyle.Fill;
            txtAddress.Location = new Point(128, 108);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ScrollBars = ScrollBars.Vertical;
            txtAddress.Size = new Size(704, 66);
            txtAddress.TabIndex = 8;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Dock = DockStyle.Fill;
            lblAddress.Font = new Font("Segoe UI", 9F);
            lblAddress.Location = new Point(3, 105);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(119, 72);
            lblAddress.TabIndex = 7;
            lblAddress.Text = "Address";
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Location = new Point(128, 73);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(704, 31);
            txtEmail.TabIndex = 6;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.Font = new Font("Segoe UI", 9F);
            lblEmail.Location = new Point(3, 70);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(119, 35);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            // 
            // txtPhone
            // 
            txtPhone.Dock = DockStyle.Fill;
            txtPhone.Location = new Point(128, 38);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(704, 31);
            txtPhone.TabIndex = 4;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Dock = DockStyle.Fill;
            lblPhone.Font = new Font("Segoe UI", 9F);
            lblPhone.Location = new Point(3, 35);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(119, 35);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "Phone";
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(128, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(704, 31);
            txtName.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Dock = DockStyle.Fill;
            lblName.Font = new Font("Segoe UI", 9F);
            lblName.Location = new Point(3, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(119, 35);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnSave);
            flowLayoutPanel1.Controls.Add(btnCancel);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 405);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(835, 65);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Image = Properties.Resources.save;
            btnSave.Location = new Point(707, 9);
            btnSave.Margin = new Padding(9);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(3);
            btnSave.Size = new Size(119, 44);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Image = Properties.Resources.cancel;
            btnCancel.Location = new Point(570, 9);
            btnCancel.Margin = new Padding(9);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(3);
            btnCancel.Size = new Size(119, 44);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 470);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tableLayoutPanel1);
            Name = "CustomerForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblName;
        private TextBox txtName;
        private Label lblId;
        private TextBox txtAddress;
        private Label lblAddress;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtPhone;
        private Label lblPhone;
        private TextBox txtId;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnSave;
        private Button btnCancel;
    }
}