using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_04
{
    class SachGiaoKhoa : Sach
    {
        private string tinhTrang;

        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }

        public SachGiaoKhoa()
        {

        }

        public SachGiaoKhoa(string maSach, string ngayNhap, int donGia, int soLuong, string nhaXuatBan, string tinhTrang)
        {
            this.maSach = maSach;
            this.ngayNhap = ngayNhap;
            this.donGia = donGia;
            this.soLuong = soLuong;
            this.nhaXuatBan = nhaXuatBan;
            this.tinhTrang = tinhTrang;
        }

        public override void Input()
        {
            Console.WriteLine();
            Console.WriteLine("== NHAP THONG TIN SACH GIAO KHOA ==");
            base.Input();
            Console.Write("TINH TRANG (MOI/CU): ");
            this.tinhTrang = Console.ReadLine();
        }

        public override void Output()
        {
            Console.WriteLine();
            Console.WriteLine("== THONG TIN SACH GIAO KHOA ==");
            base.Output();
            Console.WriteLine("TINH TRANG: {0}", this.tinhTrang);
        }

        public bool IsMatch(string value)
        {
            if (value.ToLower() == nhaXuatBan.ToLower())
                return true;
            return false;
        }
    }
}
