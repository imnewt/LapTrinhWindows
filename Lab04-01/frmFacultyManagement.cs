using Lab04.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class frmFacultyManagement : Form
    {
        public frmFacultyManagement()
        {
            InitializeComponent();
        }

        private void frmFacultyManagement_Load(object sender, EventArgs e)
        {
            try
            {
                SetGridViewStyle(dgvFaculty);
                StudentContextDB context = new StudentContextDB();
                List<Faculty> listFaculties = context.Faculties.ToList();
                BindGrid(listFaculties);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SetGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgview.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgview.BackgroundColor = Color.White;
            dgview.EnableHeadersVisualStyles = false;
            dgview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgview.AllowUserToDeleteRows = false;
            dgview.AllowUserToAddRows = false;
            dgview.AllowUserToOrderColumns = true;
            dgview.MultiSelect = false;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        

        private void BindGrid(List<Faculty> listFaculty)
        {
            dgvFaculty.Rows.Clear();
            foreach (var item in listFaculty)
            {
                int index = dgvFaculty.Rows.Add();
                dgvFaculty.Rows[index].Cells[0].Value = item.FacultyID;
                dgvFaculty.Rows[index].Cells[1].Value = item.FacultyName;
                dgvFaculty.Rows[index].Cells[2].Value = item.TotalProfessor;
            }
        }

        private Faculty GetFaculty()
        {
           Faculty f = new Faculty();
            f.FacultyID = int.Parse(txtMaKhoa.Text);
            f.FacultyName = txtTenKhoa.Text;
            f.TotalProfessor = int.Parse(txtTongGS.Text);
            return f;
        }

        private void btnAddUpdateF_Click(object sender, EventArgs e)
        {
            try
            {
                StudentContextDB context = new StudentContextDB();
                Faculty db = context.Faculties.FirstOrDefault(p => p.FacultyID.ToString() == txtMaKhoa.Text);
                if (db == null)
                {
                    Faculty f = GetFaculty();
                    context.Faculties.Add(f);
                    context.SaveChanges();
                    MessageBox.Show("Thêm Mới Dữ Liệu thành công!");
                }
                else
                {
                    db = GetFaculty();
                    context.SaveChanges();
                    MessageBox.Show("Cập nhật thành công!");
                }
                BindGrid(context.Faculties.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteF_Click(object sender, EventArgs e)
        {
            try
            {
                StudentContextDB context = new StudentContextDB();
                Faculty db = context.Faculties.FirstOrDefault(p => p.FacultyID.ToString() == txtMaKhoa.Text);
                if (db == null)
                    throw new Exception("Không tìm thấy mã khoa để xóa!");
                else
                {
                    DialogResult dlg = MessageBox.Show("Bạn có muốn xóa không?", "Cảnh Báo", MessageBoxButtons.YesNo);
                    if (dlg == DialogResult.Yes)
                    {
                        context.Faculties.Remove(db);
                        context.SaveChanges();
                        MessageBox.Show("Xóa dữ liệu thành công!");
                    }
                }
                BindGrid(context.Faculties.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvFaculty_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = e.RowIndex;
            DataGridViewRow row = dgvFaculty.Rows[i];
            txtMaKhoa.Text = dgvFaculty.Rows[i].Cells[0].Value.ToString();
            txtTenKhoa.Text = dgvFaculty.Rows[i].Cells[1].Value.ToString();
            txtTongGS.Text = dgvFaculty.Rows[i].Cells[2].Value.ToString();
        }
    }
}
