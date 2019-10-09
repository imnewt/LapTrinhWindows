using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab04.Models;

namespace Lab04
{
    public partial class frmStudentManagement : Form
    {
        public frmStudentManagement()
        {
            InitializeComponent();
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

        private void frmStudentManagement_Load(object sender, EventArgs e)
        {
            try
            {
                SetGridViewStyle(dgvStudent);
                StudentContextDB context = new StudentContextDB();
                List<Faculty> listFalculties = context.Faculties.ToList();
                List<Student> listStudent = context.Students.ToList();
                FillFalcultyCombobox(listFalculties);
                BindGrid(listStudent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Hàm binding list dữ liệu khoa vào combobox có tên hiện thị là tên khoa, giá trị là Mã khoa
        private void FillFalcultyCombobox(List<Faculty> listFalculties)
        {
            this.cmbFaculty.DataSource = listFalculties;
            this.cmbFaculty.DisplayMember = "FacultyName";
            this.cmbFaculty.ValueMember = "FacultyID";
        }

        private void BindGrid(List<Student> listStudent) //Hàm binding gridView từ list sinh viên 
        {
            dgvStudent.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgvStudent.Rows.Add();
                dgvStudent.Rows[index].Cells[0].Value = item.StudentID;
                dgvStudent.Rows[index].Cells[1].Value = item.FullName;
                if (item.Faculty != null)
                    dgvStudent.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                dgvStudent.Rows[index].Cells[3].Value = item.AverageScore + "";
            }
        }

        private Student GetStudent()   //Lấy thông tin sinh viên từ dữ liệu nhập 
        {
            Student s = new Student();
            s.StudentID = txtStudentID.Text;
            s.FullName = txtStudentName.Text;
            if (txtScore.Text != "")
                s.AverageScore = float.Parse(txtScore.Text);
            if (cmbFaculty.Text != "")
                s.FacultyID = int.Parse(cmbFaculty.SelectedValue.ToString());
            return s;
        }
        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                StudentContextDB context = new StudentContextDB();
                Student db = context.Students.FirstOrDefault(p => p.StudentID == txtStudentID.Text);
                if (db == null)  //TH insert 
                {
                    Student s = GetStudent();
                    context.Students.Add(s);
                    context.SaveChanges();
                    MessageBox.Show("Thêm Mới Dữ Liệu thành công!");
                }
                else //TH Uupdate 
                {
                    db = GetStudent();
                    context.SaveChanges();
                    MessageBox.Show("Cập nhật thành công!");
                }

                BindGrid(context.Students.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                StudentContextDB context = new StudentContextDB();
                Student db = context.Students.FirstOrDefault(p => p.StudentID == txtStudentID.Text);
                if (db == null)
                    throw new Exception("Không tìm thấy mã sinh viên để xóa!");
                else
                {
                    DialogResult dlg = MessageBox.Show("Bạn có muốn xóa không?", "Cảnh Báo", MessageBoxButtons.YesNo);
                    if (dlg == DialogResult.Yes)
                    {
                        context.Students.Remove(db);
                        context.SaveChanges();
                        MessageBox.Show("Xóa dữ liệu thành công!");
                    }
                }
                BindGrid(context.Students.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void thôngTinKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFacultyManagement formQuanLyKhoa = new frmFacultyManagement();
            formQuanLyKhoa.ShowDialog();
        }

        private void dgvStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = e.RowIndex;
            DataGridViewRow row = dgvStudent.Rows[i];
            txtStudentID.Text = dgvStudent.Rows[i].Cells[0].Value.ToString();
            txtStudentName.Text = dgvStudent.Rows[i].Cells[1].Value.ToString();
            cmbFaculty.Text = dgvStudent.Rows[i].Cells[2].Value.ToString();
            txtScore.Text = dgvStudent.Rows[i].Cells[3].Value.ToString();
        }
    }
}
