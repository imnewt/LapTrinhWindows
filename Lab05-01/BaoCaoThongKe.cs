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
    public partial class BaoCaoThongKe : Form
    {
        ProductDB context = new ProductDB();
        public BaoCaoThongKe()
        {
            InitializeComponent();
        }

        private void BaoCaoThongKe_Load(object sender, EventArgs e)
        {
            this.rptvMain.Visible = false;
        }

        private void rdXemTheoNgay_CheckedChanged(object sender, EventArgs e)
        {
            dtpNgay.Enabled = true;
            dtpThang.Enabled = false;
            dtpFrom.Enabled = false;
            dtpTo.Enabled = false;
        }

        private void rdXemTheoThang_CheckedChanged(object sender, EventArgs e)
        {
            dtpNgay.Enabled = false;
            dtpThang.Enabled = true;
            dtpFrom.Enabled = false;
            dtpTo.Enabled = false;
        }

        private void rdXemTuNgay_CheckedChanged(object sender, EventArgs e)
        {
            dtpNgay.Enabled = false;
            dtpThang.Enabled = false;
            dtpFrom.Enabled = true;
            dtpTo.Enabled = true;
        }

        private void btnInXem_Click(object sender, EventArgs e)
        {
            if (rdXemTheoNgay.Checked == true)
            {
                List<Order> listOrder = context.Orders.ToList();
                this.rptvMain.LocalReport.ReportPath = "ThongKeHoaDonTheoNgay.rdlc";
                var reportDataSource = new ReportDataSource("XemTheoNgayDataSet", listOrder);
                this.rptvMain.LocalReport.DataSources.Add(reportDataSource);
                this.rptvMain.LocalReport.DisplayName = "Thống Kê Hóa Đơn Theo Ngày";
                //string.Format(dtpNgay.Value.ToString("dd/MM/yyyy"))
                Invoice invoice = context.Invoices.FirstOrDefault(p => p.DeliveryDate.Day == dtpNgay.Value.Day);
                Order order = context.Orders.FirstOrDefault(p => p.InvoiceNo == invoice.InvoiceNo);

                ReportParameter[] param = new ReportParameter[2];
                //param[0] = new ReportParameter("NgayThangShort", string.Format(invoice.DeliveryDate.ToString("dd/MM/yyyy")));
                param[0] = new ReportParameter("NgayThangShort", dtpNgay.Value.ToString("dd/MM/yyyy"));
                param[1] = new ReportParameter("NgayThangLong", "Ngày " + dtpNgay.Value.ToString("dd") + " Tháng " + dtpNgay.Value.ToString("MM") + " Năm " + dtpNgay.Value.ToString("yyyy"));
                this.rptvMain.LocalReport.SetParameters(param);
            }
            //else if (rdXemTheoThang.Checked == true)
            //{
            //    Invoice invoice = context.Invoices.FirstOrDefault(p => p.InvoiceNo == cboPhieuGiaoHang.Text);
            //    List<Order> listOrder = context.Orders.Where(p => p.InvoiceNo == cboPhieuGiaoHang.Text).ToList();
            //    if (invoice == null || listOrder.Count() == 0)
            //    {
            //        MessageBox.Show("Không Tìm Thấy Đơn Hàng");
            //        return;
            //    }

            //    ReportParameter[] param = new ReportParameter[2];
            //    param[0] = new ReportParameter("SoHoaDon", invoice.InvoiceNo);
            //    param[1] = new ReportParameter("NgayGiao", string.Format("Ngày " + invoice.DeliveryDate.ToString("dd/MM/yyyy")));

            //    this.rptvMain.LocalReport.ReportPath = "Order.rdlc";  //nhớ copy report ra debug
            //    this.rptvMain.LocalReport.SetParameters(param);
            //    var reportDataSource = new ReportDataSource("OrderDataSet", listOrder);
            //    this.rptvMain.LocalReport.DataSources.Clear();
            //    this.rptvMain.LocalReport.DataSources.Add(reportDataSource);
            //    this.rptvMain.LocalReport.DisplayName = "Phiếu giao hàng";  //tên hiển thị
            //}
            //else
            //{

            //}
            this.rptvMain.Visible = true;
            this.rptvMain.RefreshReport();
        }
    }
}
