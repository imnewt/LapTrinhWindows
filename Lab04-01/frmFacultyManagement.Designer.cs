namespace Lab04
{
    partial class frmFacultyManagement
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTongGS = new System.Windows.Forms.Label();
            this.txtTongGS = new System.Windows.Forms.TextBox();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.btnDeleteF = new System.Windows.Forms.Button();
            this.btnAddUpdateF = new System.Windows.Forms.Button();
            this.lblTenKhoa = new System.Windows.Forms.Label();
            this.lblMaKhoa = new System.Windows.Forms.Label();
            this.dgvFaculty = new System.Windows.Forms.DataGridView();
            this.MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongGS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaculty)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTongGS);
            this.groupBox1.Controls.Add(this.txtTongGS);
            this.groupBox1.Controls.Add(this.txtTenKhoa);
            this.groupBox1.Controls.Add(this.txtMaKhoa);
            this.groupBox1.Controls.Add(this.btnDeleteF);
            this.groupBox1.Controls.Add(this.btnAddUpdateF);
            this.groupBox1.Controls.Add(this.lblTenKhoa);
            this.groupBox1.Controls.Add(this.lblMaKhoa);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 218);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khoa";
            // 
            // lblTongGS
            // 
            this.lblTongGS.AutoSize = true;
            this.lblTongGS.ForeColor = System.Drawing.Color.Black;
            this.lblTongGS.Location = new System.Drawing.Point(24, 105);
            this.lblTongGS.Name = "lblTongGS";
            this.lblTongGS.Size = new System.Drawing.Size(66, 13);
            this.lblTongGS.TabIndex = 9;
            this.lblTongGS.Text = "Tổng Số GS";
            // 
            // txtTongGS
            // 
            this.txtTongGS.Location = new System.Drawing.Point(96, 102);
            this.txtTongGS.Name = "txtTongGS";
            this.txtTongGS.Size = new System.Drawing.Size(59, 20);
            this.txtTongGS.TabIndex = 8;
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(96, 66);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(173, 20);
            this.txtTenKhoa.TabIndex = 7;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(96, 29);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(173, 20);
            this.txtMaKhoa.TabIndex = 6;
            // 
            // btnDeleteF
            // 
            this.btnDeleteF.Location = new System.Drawing.Point(157, 157);
            this.btnDeleteF.Name = "btnDeleteF";
            this.btnDeleteF.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteF.TabIndex = 5;
            this.btnDeleteF.Text = "Delete";
            this.btnDeleteF.UseVisualStyleBackColor = true;
            this.btnDeleteF.Click += new System.EventHandler(this.btnDeleteF_Click);
            // 
            // btnAddUpdateF
            // 
            this.btnAddUpdateF.Location = new System.Drawing.Point(27, 157);
            this.btnAddUpdateF.Name = "btnAddUpdateF";
            this.btnAddUpdateF.Size = new System.Drawing.Size(80, 23);
            this.btnAddUpdateF.TabIndex = 4;
            this.btnAddUpdateF.Text = "Add/ Update";
            this.btnAddUpdateF.UseVisualStyleBackColor = true;
            this.btnAddUpdateF.Click += new System.EventHandler(this.btnAddUpdateF_Click);
            // 
            // lblTenKhoa
            // 
            this.lblTenKhoa.AutoSize = true;
            this.lblTenKhoa.ForeColor = System.Drawing.Color.Black;
            this.lblTenKhoa.Location = new System.Drawing.Point(24, 69);
            this.lblTenKhoa.Name = "lblTenKhoa";
            this.lblTenKhoa.Size = new System.Drawing.Size(54, 13);
            this.lblTenKhoa.TabIndex = 1;
            this.lblTenKhoa.Text = "Tên Khoa";
            // 
            // lblMaKhoa
            // 
            this.lblMaKhoa.AutoSize = true;
            this.lblMaKhoa.ForeColor = System.Drawing.Color.Black;
            this.lblMaKhoa.Location = new System.Drawing.Point(24, 32);
            this.lblMaKhoa.Name = "lblMaKhoa";
            this.lblMaKhoa.Size = new System.Drawing.Size(50, 13);
            this.lblMaKhoa.TabIndex = 0;
            this.lblMaKhoa.Text = "Mã Khoa";
            // 
            // dgvFaculty
            // 
            this.dgvFaculty.AllowUserToAddRows = false;
            this.dgvFaculty.AllowUserToDeleteRows = false;
            this.dgvFaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaculty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhoa,
            this.TenKhoa,
            this.TongGS});
            this.dgvFaculty.Location = new System.Drawing.Point(342, 11);
            this.dgvFaculty.MultiSelect = false;
            this.dgvFaculty.Name = "dgvFaculty";
            this.dgvFaculty.ReadOnly = true;
            this.dgvFaculty.Size = new System.Drawing.Size(402, 238);
            this.dgvFaculty.TabIndex = 2;
            this.dgvFaculty.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFaculty_CellDoubleClick);
            // 
            // MaKhoa
            // 
            this.MaKhoa.HeaderText = "Mã Khoa";
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.ReadOnly = true;
            this.MaKhoa.Width = 80;
            // 
            // TenKhoa
            // 
            this.TenKhoa.HeaderText = "Tên Khoa";
            this.TenKhoa.Name = "TenKhoa";
            this.TenKhoa.ReadOnly = true;
            this.TenKhoa.Width = 140;
            // 
            // TongGS
            // 
            this.TongGS.HeaderText = "Tổng Số GS";
            this.TongGS.Name = "TongGS";
            this.TongGS.ReadOnly = true;
            this.TongGS.Width = 140;
            // 
            // frmFacultyManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvFaculty);
            this.Name = "frmFacultyManagement";
            this.Text = "Quản Lý Khoa";
            this.Load += new System.EventHandler(this.frmFacultyManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaculty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTongGS;
        private System.Windows.Forms.TextBox txtTongGS;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.Button btnDeleteF;
        private System.Windows.Forms.Button btnAddUpdateF;
        private System.Windows.Forms.Label lblTenKhoa;
        private System.Windows.Forms.Label lblMaKhoa;
        private System.Windows.Forms.DataGridView dgvFaculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongGS;
    }
}