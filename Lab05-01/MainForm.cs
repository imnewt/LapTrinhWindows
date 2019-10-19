using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnXuatThongTin_Click(object sender, EventArgs e)
        {
            XuatThongTin xf = new XuatThongTin();
            xf.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBaoCaoThongKe_Click(object sender, EventArgs e)
        {
            BaoCaoThongKe bf = new BaoCaoThongKe();
            bf.Show();
        }
    }
}
