namespace Lab04_04
{
    partial class Form1
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
            this.cbSeeAll = new System.Windows.Forms.CheckBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.dgvSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSoHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNgayGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSum = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.gbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSeeAll
            // 
            this.cbSeeAll.AutoSize = true;
            this.cbSeeAll.Location = new System.Drawing.Point(66, 39);
            this.cbSeeAll.Name = "cbSeeAll";
            this.cbSeeAll.Size = new System.Drawing.Size(174, 21);
            this.cbSeeAll.TabIndex = 0;
            this.cbSeeAll.Text = "Xem tất cả trong tháng";
            this.cbSeeAll.UseVisualStyleBackColor = true;
            this.cbSeeAll.CheckedChanged += new System.EventHandler(this.CbSeeAll_CheckedChanged);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(66, 85);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(134, 17);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Thời gian giao hàng";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(263, 85);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(117, 22);
            this.dtpFrom.TabIndex = 2;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.DtpFrom_ValueChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd/MM/yyyy";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(432, 85);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(117, 22);
            this.dtpTo.TabIndex = 2;
            this.dtpTo.ValueChanged += new System.EventHandler(this.DtpTo_ValueChanged);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(399, 90);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(14, 17);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "-";
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.dtpFrom);
            this.gbMain.Controls.Add(this.lblTo);
            this.gbMain.Controls.Add(this.cbSeeAll);
            this.gbMain.Controls.Add(this.dtpTo);
            this.gbMain.Controls.Add(this.lblTime);
            this.gbMain.Location = new System.Drawing.Point(27, 24);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(772, 137);
            this.gbMain.TabIndex = 4;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "Thông Tin Đơn Hàng";
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSTT,
            this.dgvSoHD,
            this.dgvNgayDat,
            this.dgvNgayGiao,
            this.dgvThanhTien});
            this.dgvMain.Location = new System.Drawing.Point(27, 167);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersWidth = 51;
            this.dgvMain.RowTemplate.Height = 24;
            this.dgvMain.Size = new System.Drawing.Size(772, 212);
            this.dgvMain.TabIndex = 5;
            this.dgvMain.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMain_CellValueChanged);
            // 
            // dgvSTT
            // 
            this.dgvSTT.HeaderText = "STT";
            this.dgvSTT.MinimumWidth = 6;
            this.dgvSTT.Name = "dgvSTT";
            this.dgvSTT.Width = 80;
            // 
            // dgvSoHD
            // 
            this.dgvSoHD.HeaderText = "Số HĐ";
            this.dgvSoHD.MinimumWidth = 6;
            this.dgvSoHD.Name = "dgvSoHD";
            this.dgvSoHD.Width = 80;
            // 
            // dgvNgayDat
            // 
            this.dgvNgayDat.HeaderText = "Ngày Đặt Hàng";
            this.dgvNgayDat.MinimumWidth = 6;
            this.dgvNgayDat.Name = "dgvNgayDat";
            this.dgvNgayDat.Width = 140;
            // 
            // dgvNgayGiao
            // 
            this.dgvNgayGiao.HeaderText = "Ngày Giao Hàng";
            this.dgvNgayGiao.MinimumWidth = 6;
            this.dgvNgayGiao.Name = "dgvNgayGiao";
            this.dgvNgayGiao.Width = 140;
            // 
            // dgvThanhTien
            // 
            this.dgvThanhTien.HeaderText = "Thành Tiền";
            this.dgvThanhTien.MinimumWidth = 6;
            this.dgvThanhTien.Name = "dgvThanhTien";
            this.dgvThanhTien.Width = 125;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(576, 398);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(82, 17);
            this.lblSum.TabIndex = 6;
            this.lblSum.Text = "Tổng Cộng:";
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(664, 395);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(135, 22);
            this.txtSum.TabIndex = 7;
            this.txtSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 432);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.gbMain);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Thông Tin Đơn Hàng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbSeeAll;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSoHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNgayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNgayGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvThanhTien;
    }
}

