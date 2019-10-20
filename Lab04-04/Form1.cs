using Lab04_04.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Model1 context = new Model1();
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                SetGridViewStyle(dgvMain);
                List<Invoice> listInvoice = context.Invoices.ToList();
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
        private void BindGrid(List<Invoice> listInvoice)
        {
            dgvMain.Rows.Clear();
            List<Order> listOrder = context.Orders.ToList();
            var count = 1;
            var sum = 0;
            foreach (var item in listInvoice)
            {
                int index = dgvMain.Rows.Add();
                dgvMain.Rows[index].Cells[0].Value = count;
                dgvMain.Rows[index].Cells[1].Value = item.InvoiceNo;
                dgvMain.Rows[index].Cells[2].Value = item.OrderDate.ToShortDateString();
                dgvMain.Rows[index].Cells[3].Value = item.DeliveryDate.ToShortDateString();
                foreach (var order in listOrder)
                {
                    if (order.InvoiceNo == item.InvoiceNo)
                    {
                        sum += (order.Price * order.Quantity);
                    }
                }
                dgvMain.Rows[index].Cells[4].Value = sum;
                sum = 0;
                count++;
            }
        }

        private void DtpFrom_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtpFrom.Value > dtpTo.Value)
                {
                    throw new Exception("NHẬP SAI MỐC THỜI GIAN!!!");
                }
                List<Invoice> listInvoice = context.Invoices.ToList();
                List<Invoice> filteredList = new List<Invoice>();
                foreach (var item in listInvoice)
                {
                    if (item.DeliveryDate.Date >= dtpFrom.Value.Date)
                    {
                        filteredList.Add(item);
                    }
                }
                BindGrid(filteredList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DtpTo_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtpTo.Value < dtpFrom.Value)
                {
                    throw new Exception("NHẬP SAI MỐC THỜI GIAN!!!");
                }
                List<Invoice> listInvoice = context.Invoices.ToList();
                List<Invoice> filteredList = new List<Invoice>();
                foreach (var item in listInvoice)
                {
                    if (item.DeliveryDate.Date <= dtpTo.Value.Date && item.DeliveryDate.Date >= dtpFrom.Value.Date)
                    {
                        filteredList.Add(item);
                    }
                }
                BindGrid(filteredList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CbSeeAll_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbSeeAll.CheckState == CheckState.Checked)
                {
                    var today = DateTime.Today;
                    List<Invoice> listInvoice = context.Invoices.ToList();
                    List<Invoice> filteredList = new List<Invoice>();
                    foreach (var item in listInvoice)
                    {
                        if (item.DeliveryDate.Date.Month == today.Month)
                        {
                            filteredList.Add(item);
                        }
                    }
                    dtpFrom.Value = new DateTime(today.Year, today.Month, 1);
                    dtpTo.Value = dtpFrom.Value.AddMonths(1).AddDays(-1);
                    BindGrid(filteredList);
                    dtpFrom.Enabled = false;
                    dtpTo.Enabled = false;
                }
                else
                {
                    dtpFrom.Enabled = true;
                    dtpTo.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DgvMain_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dgvMain.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvMain.Rows[i].Cells[4].Value);
            }
            txtSum.Text = sum.ToString();
        }
    }
}
