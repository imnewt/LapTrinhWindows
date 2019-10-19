namespace Buoi5
{
    partial class BaoCaoThongKe
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
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.rdXemTheoNgay = new System.Windows.Forms.RadioButton();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.btnInXem = new System.Windows.Forms.Button();
            this.rptvMain = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rdXemTheoThang = new System.Windows.Forms.RadioButton();
            this.dtpThang = new System.Windows.Forms.DateTimePicker();
            this.rdXemTuNgay = new System.Windows.Forms.RadioButton();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Location = new System.Drawing.Point(63, 36);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(107, 13);
            this.lblThoiGian.TabIndex = 0;
            this.lblThoiGian.Text = "Thời Gian Giao Hàng";
            // 
            // rdXemTheoNgay
            // 
            this.rdXemTheoNgay.AutoSize = true;
            this.rdXemTheoNgay.Location = new System.Drawing.Point(194, 36);
            this.rdXemTheoNgay.Name = "rdXemTheoNgay";
            this.rdXemTheoNgay.Size = new System.Drawing.Size(102, 17);
            this.rdXemTheoNgay.TabIndex = 1;
            this.rdXemTheoNgay.TabStop = true;
            this.rdXemTheoNgay.Text = "Xem Theo Ngày";
            this.rdXemTheoNgay.UseVisualStyleBackColor = true;
            this.rdXemTheoNgay.CheckedChanged += new System.EventHandler(this.rdXemTheoNgay_CheckedChanged);
            // 
            // dtpNgay
            // 
            this.dtpNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpNgay.Location = new System.Drawing.Point(333, 36);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(108, 20);
            this.dtpNgay.TabIndex = 2;
            // 
            // btnInXem
            // 
            this.btnInXem.Location = new System.Drawing.Point(467, 150);
            this.btnInXem.Name = "btnInXem";
            this.btnInXem.Size = new System.Drawing.Size(108, 23);
            this.btnInXem.TabIndex = 3;
            this.btnInXem.Text = "In / Xem";
            this.btnInXem.UseVisualStyleBackColor = true;
            this.btnInXem.Click += new System.EventHandler(this.btnInXem_Click);
            // 
            // rptvMain
            // 
            this.rptvMain.Location = new System.Drawing.Point(32, 248);
            this.rptvMain.Name = "rptvMain";
            this.rptvMain.Size = new System.Drawing.Size(714, 392);
            this.rptvMain.TabIndex = 4;
            // 
            // rdXemTheoThang
            // 
            this.rdXemTheoThang.AutoSize = true;
            this.rdXemTheoThang.Location = new System.Drawing.Point(194, 72);
            this.rdXemTheoThang.Name = "rdXemTheoThang";
            this.rdXemTheoThang.Size = new System.Drawing.Size(108, 17);
            this.rdXemTheoThang.TabIndex = 1;
            this.rdXemTheoThang.TabStop = true;
            this.rdXemTheoThang.Text = "Xem Theo Tháng";
            this.rdXemTheoThang.UseVisualStyleBackColor = true;
            this.rdXemTheoThang.CheckedChanged += new System.EventHandler(this.rdXemTheoThang_CheckedChanged);
            // 
            // dtpThang
            // 
            this.dtpThang.CustomFormat = "MM/yyyy";
            this.dtpThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpThang.Location = new System.Drawing.Point(333, 72);
            this.dtpThang.Name = "dtpThang";
            this.dtpThang.Size = new System.Drawing.Size(108, 20);
            this.dtpThang.TabIndex = 2;
            // 
            // rdXemTuNgay
            // 
            this.rdXemTuNgay.AutoSize = true;
            this.rdXemTuNgay.Location = new System.Drawing.Point(194, 112);
            this.rdXemTuNgay.Name = "rdXemTuNgay";
            this.rdXemTuNgay.Size = new System.Drawing.Size(90, 17);
            this.rdXemTuNgay.TabIndex = 1;
            this.rdXemTuNgay.TabStop = true;
            this.rdXemTuNgay.Text = "Xem Từ Ngày";
            this.rdXemTuNgay.UseVisualStyleBackColor = true;
            this.rdXemTuNgay.CheckedChanged += new System.EventHandler(this.rdXemTuNgay_CheckedChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpFrom.Location = new System.Drawing.Point(333, 112);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(108, 20);
            this.dtpFrom.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "~";
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd/MM/yyyy";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpTo.Location = new System.Drawing.Point(467, 112);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(108, 20);
            this.dtpTo.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblThoiGian);
            this.groupBox1.Controls.Add(this.rdXemTheoNgay);
            this.groupBox1.Controls.Add(this.btnInXem);
            this.groupBox1.Controls.Add(this.dtpNgay);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.rdXemTheoThang);
            this.groupBox1.Controls.Add(this.dtpThang);
            this.groupBox1.Controls.Add(this.rdXemTuNgay);
            this.groupBox1.Location = new System.Drawing.Point(32, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 195);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Đơn Hàng";
            // 
            // BaoCaoThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 693);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rptvMain);
            this.Name = "BaoCaoThongKe";
            this.Text = "BaoCaoThongKe";
            this.Load += new System.EventHandler(this.BaoCaoThongKe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.RadioButton rdXemTheoNgay;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Button btnInXem;
        private Microsoft.Reporting.WinForms.ReportViewer rptvMain;
        private System.Windows.Forms.RadioButton rdXemTheoThang;
        private System.Windows.Forms.DateTimePicker dtpThang;
        private System.Windows.Forms.RadioButton rdXemTuNgay;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}