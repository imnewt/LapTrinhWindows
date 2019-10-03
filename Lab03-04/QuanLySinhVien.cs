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
    public partial class QuanLySinhVien : Form
    {
        public QuanLySinhVien()
        {
            InitializeComponent();
        }

        private void QuanLySinhVien_Load(object sender, EventArgs e)
        {
            SinhVien.listSinhVien.Add(new SinhVien("1711062389", "Mai Tấn Trực", "Công Nghệ Thông Tin", 7.5));
            SinhVien.listSinhVien.Add(new SinhVien("1711062388", "Nai Tấn Trực", "Công Nghệ Thông Tin", 7.5));

            FillData(SinhVien.listSinhVien);
        }

        private void FillData(List<SinhVien> listSinhVien)
        {
            this.dataGridView1.Rows.Clear();
            foreach (SinhVien sv in listSinhVien)
            {
                var index = this.dataGridView1.Rows.Add();

                this.dataGridView1.Rows[index].Cells[0].Value = (index + 1).ToString();
                this.dataGridView1.Rows[index].Cells[1].Value = sv.mssv.ToString();
                this.dataGridView1.Rows[index].Cells[2].Value = sv.tenSinhVien.ToString();
                this.dataGridView1.Rows[index].Cells[3].Value = sv.khoa.ToString();
                this.dataGridView1.Rows[index].Cells[4].Value = sv.diemTB.ToString();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ThemSinhVien formThem = new ThemSinhVien();
            formThem.ShowDialog();

            FillData(SinhVien.listSinhVien);
        }

        
        private void tsFind_TextChanged(object sender, EventArgs e)
        {
            List<SinhVien> list = SinhVien.listSinhVien.Where(p => p.tenSinhVien.ToLower().Contains(tsFind.Text.Trim().ToLower())).ToList();
            FillData(list);
        }

    }
}
