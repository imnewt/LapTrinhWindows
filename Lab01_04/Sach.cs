using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_04
{
    class Sach
    {
        protected string maSach;
        protected string ngayNhap;
        protected int donGia;
        protected int soLuong;
        protected string nhaXuatBan;

        public string MaSach { get => maSach; set => maSach = value; }
        public string NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string NhaXuatBan { get => nhaXuatBan; set => nhaXuatBan = value; }

        public virtual void Input()
        {
            Console.Write("MA SACH: ");
            this.maSach = Console.ReadLine();
            Console.Write("NGAY NHAP: ");
            this.ngayNhap = Console.ReadLine();
            Console.Write("DON GIA: ");
            this.donGia = int.Parse(Console.ReadLine());
            Console.Write("SO LUONG: ");
            this.soLuong = int.Parse(Console.ReadLine());
            Console.Write("NHA XUAT BAN: ");
            this.nhaXuatBan = Console.ReadLine();
        }

        public virtual void Output()
        {
            Console.WriteLine("MA SACH: {0}", this.maSach);
            Console.WriteLine("NGAY NHAP: {0}", this.ngayNhap);
            Console.WriteLine("DON GIA: {0}", this.donGia);
            Console.WriteLine("SO LUONG: {0}", this.soLuong);
            Console.WriteLine("NHA XUAT BAN: {0}", this.NhaXuatBan);
        }
    }
}
