using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_04
{
    public partial class Form4 : Form
    {
        class MonHoc
        {
            public int id { get; set; }

            public int soMon { get; set; }
            public int tenMon { get; set; }
            
        }

        List<MonHoc> dsMonHoc = new List<MonHoc>();
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            cboChuyenNganh.Items.Add("Hệ Thống Thông Tin");
            cboChuyenNganh.Items.Add("Công Nghệ Phần Mềm");
            cboChuyenNganh.Items.Add("An Toàn Thông Tin");

            lstBang1.Items.Add("Cơ Sở Dữ Liệu");
            lstBang1.Items.Add("Cơ sở dữ liệu NC");
            lstBang1.Items.Add("PT TK Hệ Thống Thông Tin");
        }

        private void chkNam_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNam.CheckState == CheckState.Checked)
            {
                chkNu.CheckState = CheckState.Unchecked;
            }
        }

        private void chkNu_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNu.CheckState == CheckState.Checked)
            {
                chkNam.CheckState = CheckState.Unchecked;
            }
        }

        private void cboChuyenNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChuyenNganh.Text == "Hệ Thống Thông Tin")
            {
                lstBang1.Items.Clear();
                lstBang2.Items.Clear();
                lstBang1.Items.Add("Cơ Sở Dữ Liệu");
                lstBang1.Items.Add("Cơ Sở Dữ Liệu NC");
                lstBang1.Items.Add("PT TK Hệ Thống Thông Tin");
            }
            if (cboChuyenNganh.Text == "Công Nghệ Phần Mềm")
            {
                lstBang1.Items.Clear();
                lstBang2.Items.Clear();
                lstBang1.Items.Add("Cơ Sở Dữ Liệu");
                lstBang1.Items.Add("Kiểm Thử Phần Mềm");
                lstBang1.Items.Add("Lập Trình Java");
            }
            if (cboChuyenNganh.Text == "An Toàn Thông Tin")
            {
                lstBang1.Items.Clear();
                lstBang2.Items.Clear();
                lstBang1.Items.Add("Cơ Sở Dữ Liệu");
                lstBang1.Items.Add("Che Giấu Thông Tin");
                lstBang1.Items.Add("Mã Hóa Thông Tin");
                lstBang1.Items.Add("Ẩn Thông Tin Trên DL Số");
            }
        }

        //List<string> dsChon = new List<string>();
        private void btnThem_Click(object sender, EventArgs e)
        {
            lstBang2.Items.Add(lstBang1.SelectedItem.ToString());
            lstBang1.Items.Remove(lstBang1.SelectedItem);
            
        }

        private void btnBo_Click(object sender, EventArgs e)
        {
            lstBang1.Items.Add(lstBang2.SelectedItem.ToString());
            lstBang2.Items.Remove(lstBang2.SelectedItem);
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa hết dữ liệu vừa nhập??", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txtMaSinhVien.Text = null;
                txtHoTen.Text = null;
                chkNam.CheckState = CheckState.Unchecked;
                chkNu.CheckState = CheckState.Unchecked;
                cboChuyenNganh.Text = "Hệ Thống Thông Tin";
                lstBang1.Items.Clear();
                lstBang2.Items.Clear();
                lstBang1.Items.Add("Cơ Sở Dữ Liệu");
                lstBang1.Items.Add("Cơ Sở Dữ Liệu NC");
                lstBang1.Items.Add("PT TK Hệ Thống Thông Tin");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Nhập dữ liệu vào bảng??", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = txtMaSinhVien.Text;
                dataGridView1.Rows[n].Cells[1].Value = txtHoTen.Text;
                dataGridView1.Rows[n].Cells[2].Value = cboChuyenNganh.Text;
                if (chkNam.CheckState == CheckState.Unchecked && chkNu.CheckState == CheckState.Unchecked) {
                    dataGridView1.Rows[n].Cells[3].Value = null;
                }
                else if (chkNam.CheckState == CheckState.Checked)
                {
                    dataGridView1.Rows[n].Cells[3].Value = "Nam";
                }
                else
                {
                    dataGridView1.Rows[n].Cells[3].Value = "Nu";
                }
                dataGridView1.Rows[n].Cells[4].Value = lstBang2.Items.Count.ToString();


                //dsMonHoc[n].soMon = int.Parse(lstBang2.Items.Count.ToString());
                //for (int i = 0; i < dsMonHoc[n].soMon; i++)
                //{
                //    dsMonHoc[n].tenMon
                //}



                // DETELE INPUTED DATA
                txtMaSinhVien.Text = null;
                txtHoTen.Text = null;
                chkNam.CheckState = CheckState.Unchecked;
                chkNu.CheckState = CheckState.Unchecked;
                cboChuyenNganh.Text = "Hệ Thống Thông Tin";
                lstBang1.Items.Clear();
                lstBang2.Items.Clear();
                lstBang1.Items.Add("Cơ Sở Dữ Liệu");
                lstBang1.Items.Add("Cơ Sở Dữ Liệu NC");
                lstBang1.Items.Add("PT TK Hệ Thống Thông Tin");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[i];
            txtMaSinhVien.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtHoTen.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            cboChuyenNganh.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();

            if (dataGridView1.Rows[i].Cells[3].Value == "Nam")
            {
                chkNam.CheckState = CheckState.Checked;
            }
            else if (dataGridView1.Rows[i].Cells[3].Value == "Nu")
            {
                chkNu.CheckState = CheckState.Checked;
            }
            else
            {
                chkNam.CheckState = CheckState.Unchecked;
                chkNu.CheckState = CheckState.Unchecked;
            }

            
        }
    }
}
