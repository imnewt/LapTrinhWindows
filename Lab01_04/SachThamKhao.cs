using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_04
{
    class SachThamKhao : Sach
    {
        private int thue;

        public int Thue { get => thue; set => thue = value; }

        public SachThamKhao()
        {

        }

        public SachThamKhao(string maSach, string ngayNhap, int donGia, int soLuong, string nhaXuatBan, int thue)
        {
            this.maSach = maSach;
            this.ngayNhap = ngayNhap;
            this.donGia = donGia;
            this.soLuong = soLuong;
            this.nhaXuatBan = nhaXuatBan;
            this.thue = thue;
        }

        public override void Input()
        {
            Console.WriteLine();
            Console.WriteLine("== NHAP THONG TIN SACH THAM KHAO ==");
            base.Input();
            Console.Write("THUE: ");
            this.thue = int.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            Console.WriteLine();
            Console.WriteLine("== THONG TIN SACH THAM KHAO ==");
            base.Output();
            Console.WriteLine("THUE: {0}", this.thue);
        }
    }
}
