namespace Buoi5
{
    partial class XuatThongTin
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
            this.rdPhieuGiaoHang = new System.Windows.Forms.RadioButton();
            this.rdBangBaoGia = new System.Windows.Forms.RadioButton();
            this.cboPhieuGiaoHang = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXuat = new System.Windows.Forms.Button();
            this.rptvMain = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdPhieuGiaoHang
            // 
            this.rdPhieuGiaoHang.AutoSize = true;
            this.rdPhieuGiaoHang.Location = new System.Drawing.Point(77, 70);
            this.rdPhieuGiaoHang.Name = "rdPhieuGiaoHang";
            this.rdPhieuGiaoHang.Size = new System.Drawing.Size(130, 17);
            this.rdPhieuGiaoHang.TabIndex = 1;
            this.rdPhieuGiaoHang.TabStop = true;
            this.rdPhieuGiaoHang.Text = "Xem Phiếu Giao Hàng";
            this.rdPhieuGiaoHang.UseVisualStyleBackColor = true;
            this.rdPhieuGiaoHang.CheckedChanged += new System.EventHandler(this.rdPhieuGiaoHang_CheckedChanged);
            // 
            // rdBangBaoGia
            // 
            this.rdBangBaoGia.AutoSize = true;
            this.rdBangBaoGia.Location = new System.Drawing.Point(77, 26);
            this.rdBangBaoGia.Name = "rdBangBaoGia";
            this.rdBangBaoGia.Size = new System.Drawing.Size(167, 17);
            this.rdBangBaoGia.TabIndex = 0;
            this.rdBangBaoGia.TabStop = true;
            this.rdBangBaoGia.Text = "Xem Bảng Báo Giá Sản Phẩm";
            this.rdBangBaoGia.UseVisualStyleBackColor = true;
            this.rdBangBaoGia.CheckedChanged += new System.EventHandler(this.rdBangBaoGia_CheckedChanged);
            // 
            // cboPhieuGiaoHang
            // 
            this.cboPhieuGiaoHang.FormattingEnabled = true;
            this.cboPhieuGiaoHang.Location = new System.Drawing.Point(276, 66);
            this.cboPhieuGiaoHang.Name = "cboPhieuGiaoHang";
            this.cboPhieuGiaoHang.Size = new System.Drawing.Size(272, 21);
            this.cboPhieuGiaoHang.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboPhieuGiaoHang);
            this.groupBox1.Controls.Add(this.rdBangBaoGia);
            this.groupBox1.Controls.Add(this.rdPhieuGiaoHang);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(805, 118);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Báo Cáo";
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(438, 148);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(134, 23);
            this.btnXuat.TabIndex = 4;
            this.btnXuat.Text = "Xuất Report";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // rptvMain
            // 
            this.rptvMain.Location = new System.Drawing.Point(24, 202);
            this.rptvMain.Name = "rptvMain";
            this.rptvMain.Size = new System.Drawing.Size(805, 423);
            this.rptvMain.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 653);
            this.Controls.Add(this.rptvMain);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Xuất thông tin Report";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdPhieuGiaoHang;
        private System.Windows.Forms.RadioButton rdBangBaoGia;
        private System.Windows.Forms.ComboBox cboPhieuGiaoHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXuat;
        private Microsoft.Reporting.WinForms.ReportViewer rptvMain;
    }
}

