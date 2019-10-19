namespace Buoi5
{
    partial class MainForm
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
            this.btnBaoCaoThongKe = new System.Windows.Forms.Button();
            this.btnXuatThongTin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBaoCaoThongKe
            // 
            this.btnBaoCaoThongKe.Location = new System.Drawing.Point(140, 146);
            this.btnBaoCaoThongKe.Name = "btnBaoCaoThongKe";
            this.btnBaoCaoThongKe.Size = new System.Drawing.Size(187, 51);
            this.btnBaoCaoThongKe.TabIndex = 0;
            this.btnBaoCaoThongKe.Text = "Xem Báo Cáo Thống Kê";
            this.btnBaoCaoThongKe.UseVisualStyleBackColor = true;
            this.btnBaoCaoThongKe.Click += new System.EventHandler(this.btnBaoCaoThongKe_Click);
            // 
            // btnXuatThongTin
            // 
            this.btnXuatThongTin.Location = new System.Drawing.Point(140, 58);
            this.btnXuatThongTin.Name = "btnXuatThongTin";
            this.btnXuatThongTin.Size = new System.Drawing.Size(187, 50);
            this.btnXuatThongTin.TabIndex = 1;
            this.btnXuatThongTin.Text = "Xuất Thông Tin Report";
            this.btnXuatThongTin.UseVisualStyleBackColor = true;
            this.btnXuatThongTin.Click += new System.EventHandler(this.btnXuatThongTin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 290);
            this.Controls.Add(this.btnXuatThongTin);
            this.Controls.Add(this.btnBaoCaoThongKe);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBaoCaoThongKe;
        private System.Windows.Forms.Button btnXuatThongTin;
    }
}