using Buoi5.Entities;
using Microsoft.Reporting.WinForms;
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
    public partial class XuatThongTin : Form
    {

        ProductDB context = new ProductDB();
        public XuatThongTin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.rptvMain.Visible = false;
            cboPhieuGiaoHang.Enabled = false;

            List<Invoice> listInvoices = context.Invoices.ToList();
            FillInvoiceCombobox(listInvoices);
        }

        private void FillInvoiceCombobox(List<Invoice> listInvoices)
        {
            this.cboPhieuGiaoHang.DataSource = listInvoices;
            this.cboPhieuGiaoHang.DisplayMember = "InvoiceNo";
        }

        private void rdPhieuGiaoHang_CheckedChanged(object sender, EventArgs e)
        {
            cboPhieuGiaoHang.Enabled = true;
        }

        private void rdBangBaoGia_CheckedChanged(object sender, EventArgs e)
        {
            cboPhieuGiaoHang.Enabled = false;
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (rdBangBaoGia.Checked == true) //TH báo giá 
            {
                List<Product> listProduct = context.Products.ToList();
                this.rptvMain.LocalReport.ReportPath = "Product.rdlc";
                var reportDataSource = new ReportDataSource("ProductDataSet", listProduct);
                this.rptvMain.LocalReport.DataSources.Add(reportDataSource);
                this.rptvMain.LocalReport.DisplayName = "Bảng Báo Giá";
            }
            else
            {
                Invoice invoice = context.Invoices.FirstOrDefault(p => p.InvoiceNo == cboPhieuGiaoHang.Text);
                List<Order> listOrder = context.Orders.Where(p => p.InvoiceNo == cboPhieuGiaoHang.Text).ToList();
                if (invoice == null || listOrder.Count() == 0)
                {
                    MessageBox.Show("Không Tìm Thấy Đơn Hàng");
                    return;
                }
                
                ReportParameter[] param = new ReportParameter[2];
                param[0] = new ReportParameter("SoHoaDon", invoice.InvoiceNo);
                param[1] = new ReportParameter("NgayGiao", string.Format("Ngày " + invoice.DeliveryDate.ToString("dd/MM/yyyy")));

                this.rptvMain.LocalReport.ReportPath = "Order.rdlc";  //nhớ copy report ra debug
                this.rptvMain.LocalReport.SetParameters(param);
                var reportDataSource = new ReportDataSource("OrderDataSet", listOrder);
                this.rptvMain.LocalReport.DataSources.Clear();
                this.rptvMain.LocalReport.DataSources.Add(reportDataSource);
                this.rptvMain.LocalReport.DisplayName = "Phiếu giao hàng";  //tên hiển thị
            }
            this.rptvMain.Visible = true;
            this.rptvMain.RefreshReport();
        }
    }
}
