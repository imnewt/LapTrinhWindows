using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class ThemSinhVien : Form
    {
        public ThemSinhVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try {
                var err = 0;
                SinhVien sv = new SinhVien();
                sv.mssv = txtMSSV.Text;
                sv.tenSinhVien = txtTenSinhVien.Text;
                sv.khoa = cboKhoa.Text;
                sv.diemTB = double.Parse(txtDiemTrungBinh.Text);

                foreach (SinhVien sinhvien in SinhVien.listSinhVien)
                {
                    if (sv.mssv == sinhvien.mssv)
                    {
                        MessageBox.Show("Trùng Mã Số Sinh Viên!!!");
                        err += 1;
                        txtMSSV.Text = null;
                        break;
                    }
                }

                if (sv.diemTB < 0 || sv.diemTB > 10)
                {
                    MessageBox.Show("Điểm Chỉ Trong Phạm Vi Từ 1-10!!!");
                    err += 1;
                    txtDiemTrungBinh.Text = null;
                }

                if (err == 0)
                {
                    SinhVien.listSinhVien.Add(sv);
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ThemSinhVien_Load(object sender, EventArgs e)
        {
            cboKhoa.Items.Add("Công Nghệ Thông Tin");
            cboKhoa.Items.Add("Ngôn Ngữ Anh");
            cboKhoa.Items.Add("Quản Trị Kinh Doanh");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
