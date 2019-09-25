namespace Lab02_04
{
    partial class Form4
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnBo = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lstBang2 = new System.Windows.Forms.ListBox();
            this.lstBang1 = new System.Windows.Forms.ListBox();
            this.chkNu = new System.Windows.Forms.CheckBox();
            this.chkNam = new System.Windows.Forms.CheckBox();
            this.cboChuyenNganh = new System.Windows.Forms.ComboBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblChuyenNganh = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtMaSinhVien = new System.Windows.Forms.TextBox();
            this.lblMaSinhVien = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dvwMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvwHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvwTenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvwGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvwSoMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnBo);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.lstBang2);
            this.groupBox1.Controls.Add(this.lstBang1);
            this.groupBox1.Controls.Add(this.chkNu);
            this.groupBox1.Controls.Add(this.chkNam);
            this.groupBox1.Controls.Add(this.cboChuyenNganh);
            this.groupBox1.Controls.Add(this.lblGioiTinh);
            this.groupBox1.Controls.Add(this.lblChuyenNganh);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.lblHoTen);
            this.groupBox1.Controls.Add(this.txtMaSinhVien);
            this.groupBox1.Controls.Add(this.lblMaSinhVien);
            this.groupBox1.Location = new System.Drawing.Point(99, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 331);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(370, 290);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa Chọn";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(224, 290);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(103, 23);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu Thông Tin";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnBo
            // 
            this.btnBo.Location = new System.Drawing.Point(333, 225);
            this.btnBo.Name = "btnBo";
            this.btnBo.Size = new System.Drawing.Size(41, 29);
            this.btnBo.TabIndex = 6;
            this.btnBo.Text = "<";
            this.btnBo.UseVisualStyleBackColor = true;
            this.btnBo.Click += new System.EventHandler(this.btnBo_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(333, 190);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(41, 29);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = ">";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lstBang2
            // 
            this.lstBang2.FormattingEnabled = true;
            this.lstBang2.Location = new System.Drawing.Point(398, 181);
            this.lstBang2.Name = "lstBang2";
            this.lstBang2.Size = new System.Drawing.Size(153, 82);
            this.lstBang2.TabIndex = 5;
            // 
            // lstBang1
            // 
            this.lstBang1.FormattingEnabled = true;
            this.lstBang1.Location = new System.Drawing.Point(160, 181);
            this.lstBang1.Name = "lstBang1";
            this.lstBang1.Size = new System.Drawing.Size(153, 82);
            this.lstBang1.TabIndex = 5;
            // 
            // chkNu
            // 
            this.chkNu.AutoSize = true;
            this.chkNu.Location = new System.Drawing.Point(346, 148);
            this.chkNu.Name = "chkNu";
            this.chkNu.Size = new System.Drawing.Size(40, 17);
            this.chkNu.TabIndex = 4;
            this.chkNu.Text = "Nữ";
            this.chkNu.UseVisualStyleBackColor = true;
            this.chkNu.CheckedChanged += new System.EventHandler(this.chkNu_CheckedChanged);
            // 
            // chkNam
            // 
            this.chkNam.AutoSize = true;
            this.chkNam.Location = new System.Drawing.Point(265, 148);
            this.chkNam.Name = "chkNam";
            this.chkNam.Size = new System.Drawing.Size(48, 17);
            this.chkNam.TabIndex = 3;
            this.chkNam.Text = "Nam";
            this.chkNam.UseVisualStyleBackColor = true;
            this.chkNam.CheckedChanged += new System.EventHandler(this.chkNam_CheckedChanged);
            // 
            // cboChuyenNganh
            // 
            this.cboChuyenNganh.FormattingEnabled = true;
            this.cboChuyenNganh.Location = new System.Drawing.Point(265, 111);
            this.cboChuyenNganh.Name = "cboChuyenNganh";
            this.cboChuyenNganh.Size = new System.Drawing.Size(235, 21);
            this.cboChuyenNganh.TabIndex = 2;
            this.cboChuyenNganh.Text = "Hệ Thống Thông Tin";
            this.cboChuyenNganh.SelectedIndexChanged += new System.EventHandler(this.cboChuyenNganh_SelectedIndexChanged);
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(157, 148);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(51, 13);
            this.lblGioiTinh.TabIndex = 0;
            this.lblGioiTinh.Text = "Giới Tính";
            // 
            // lblChuyenNganh
            // 
            this.lblChuyenNganh.AutoSize = true;
            this.lblChuyenNganh.Location = new System.Drawing.Point(157, 111);
            this.lblChuyenNganh.Name = "lblChuyenNganh";
            this.lblChuyenNganh.Size = new System.Drawing.Size(78, 13);
            this.lblChuyenNganh.TabIndex = 0;
            this.lblChuyenNganh.Text = "Chuyên Ngành";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(265, 71);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(235, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(157, 74);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(43, 13);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ Tên";
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Location = new System.Drawing.Point(265, 37);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.Size = new System.Drawing.Size(235, 20);
            this.txtMaSinhVien.TabIndex = 1;
            // 
            // lblMaSinhVien
            // 
            this.lblMaSinhVien.AutoSize = true;
            this.lblMaSinhVien.Location = new System.Drawing.Point(157, 40);
            this.lblMaSinhVien.Name = "lblMaSinhVien";
            this.lblMaSinhVien.Size = new System.Drawing.Size(70, 13);
            this.lblMaSinhVien.TabIndex = 0;
            this.lblMaSinhVien.Text = "Mã Sinh Viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvwMSSV,
            this.dvwHoTen,
            this.dvwTenKhoa,
            this.dvwGioiTinh,
            this.dvwSoMon});
            this.dataGridView1.Location = new System.Drawing.Point(99, 392);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(667, 228);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // dvwMSSV
            // 
            this.dvwMSSV.HeaderText = "MSSV";
            this.dvwMSSV.Name = "dvwMSSV";
            // 
            // dvwHoTen
            // 
            this.dvwHoTen.HeaderText = "Họ Tên";
            this.dvwHoTen.Name = "dvwHoTen";
            this.dvwHoTen.Width = 200;
            // 
            // dvwTenKhoa
            // 
            this.dvwTenKhoa.HeaderText = "Tên Khoa";
            this.dvwTenKhoa.Name = "dvwTenKhoa";
            this.dvwTenKhoa.Width = 180;
            // 
            // dvwGioiTinh
            // 
            this.dvwGioiTinh.HeaderText = "Giới Tính";
            this.dvwGioiTinh.Name = "dvwGioiTinh";
            // 
            // dvwSoMon
            // 
            this.dvwSoMon.HeaderText = "Số Môn";
            this.dvwSoMon.Name = "dvwSoMon";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 647);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form4";
            this.Text = "Nhập Liệu Sinh Viên";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtMaSinhVien;
        private System.Windows.Forms.Label lblMaSinhVien;
        private System.Windows.Forms.Label lblChuyenNganh;
        private System.Windows.Forms.CheckBox chkNu;
        private System.Windows.Forms.CheckBox chkNam;
        private System.Windows.Forms.ComboBox cboChuyenNganh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnBo;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ListBox lstBang2;
        private System.Windows.Forms.ListBox lstBang1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvwMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvwHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvwTenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvwGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvwSoMon;
    }
}

