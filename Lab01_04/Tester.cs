using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_04
{
    class NXB : IComparable
    {
        public string tenNXB { get; set; }
        public int soLuongSach { get; set; }
        public int CompareTo(object obj)
        {
            int iCompare = this.soLuongSach - (obj as NXB).soLuongSach;
            return iCompare;
        }
    }
    class Tester
    {
        static void Main(string[] args)
        {
            
            List<Sach> dsSach = new List<Sach>();
            List<SachGiaoKhoa> dsSachGiaoKhoa = new List<SachGiaoKhoa>();
            List<SachThamKhao> dsSachThamKhao = new List<SachThamKhao>();

            SachGiaoKhoa sgk1 = new SachGiaoKhoa("DD", "18/09/2019", 5000, 20, "A", "Moi");
            SachGiaoKhoa sgk2 = new SachGiaoKhoa("TH", "18/09/2019", 3000, 50, "X", "Cu");
            SachGiaoKhoa sgk3 = new SachGiaoKhoa("HH", "18/09/2019", 1000, 5, "X", "Moi");

            
            SachThamKhao stk1 = new SachThamKhao("KN", "18/09/2019", 4000, 15, "B", 400);
            SachThamKhao stk2 = new SachThamKhao("LG", "18/09/2019", 10000, 100, "X", 500);
            SachThamKhao stk3 = new SachThamKhao("AL", "18/09/2019", 7000, 200, "Z", 150);
            SachThamKhao stk4 = new SachThamKhao("WD", "18/09/2019", 1500, 30, "B", 800);
            SachThamKhao stk5 = new SachThamKhao("CS", "18/09/2019", 5500, 10, "C", 1000);

            dsSachGiaoKhoa.Add(sgk1);
            dsSachGiaoKhoa.Add(sgk2);
            dsSachGiaoKhoa.Add(sgk3);

            dsSachThamKhao.Add(stk1);
            dsSachThamKhao.Add(stk2);
            dsSachThamKhao.Add(stk3);
            dsSachThamKhao.Add(stk4);
            dsSachThamKhao.Add(stk5);

            byte option;

            do
            {
                Console.WriteLine();
                Console.WriteLine("1. NHAP THONG TIN SACH GIAO KHOA.");
                Console.WriteLine("2. NHAP THONG TIN SACH THAM KHAO.");
                Console.WriteLine("3. XUAT THONG TIN SACH GIAO KHOA.");
                Console.WriteLine("4. XUAT THONG TIN SACH THAM KHAO.");
                Console.WriteLine("5. TINH TONG THANH TIEN SACH GIAO KHOA.");
                Console.WriteLine("6. TINH TONG THANH TIEN SACH THAM KHAO.");
                Console.WriteLine("7. XUAT RA CAC SACH GIAO KHOA CUA NHA XUAT BAN X.");
                Console.WriteLine("8. XUAT DANH SACH NHA XUAT BAN CO NHIEU TONG SO SACH THAM KHAO NHAT.");
                Console.WriteLine("9. NHAP VAO 1 MA SACH DE TIM KIEM VA XUAT RA TONG THANH TIEN (NEU CO).");
                Console.WriteLine("0. LUU VA THOAT");
                Console.Write("> ");
                option = Convert.ToByte(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            SachGiaoKhoa sgk = new SachGiaoKhoa();
                            sgk.Input();
                            dsSachGiaoKhoa.Add(sgk);
                            dsSach.Add(sgk);
                            break;
                        }
                    case 2:
                        {
                            SachThamKhao stk = new SachThamKhao();
                            stk.Input();
                            dsSachThamKhao.Add(stk);
                            dsSach.Add(stk);
                            break;
                        }
                    case 3:
                        {
                            foreach (SachGiaoKhoa sgk in dsSachGiaoKhoa)
                            {
                                sgk.Output();
                            }
                            break;
                        }
                    case 4:
                        {
                            foreach (SachThamKhao stk in dsSachThamKhao)
                            {
                                stk.Output();
                            }
                            break;
                        }
                    case 5:
                        {
                            double tongTienSGK = 0;
                            foreach (SachGiaoKhoa sgk in dsSachGiaoKhoa)
                            {
                                if (sgk.TinhTrang.ToLower() == "moi")
                                {
                                    tongTienSGK += sgk.SoLuong * sgk.DonGia;
                                }
                                else
                                {
                                    tongTienSGK += sgk.SoLuong * sgk.DonGia * 0.5;
                                }
                            }
                            Console.WriteLine("\nTONG THANH TIEN SACH GIAO KHOA LA: " + tongTienSGK);
                            break;
                        }
                    case 6:
                        {
                            double tongTienSTK = 0;
                            foreach (SachThamKhao stk in dsSachThamKhao)
                            {
                                tongTienSTK += stk.SoLuong * stk.DonGia + stk.Thue;
                            }
                            Console.WriteLine("\nTONG THANH TIEN SACH THAM KHAO LA: " + tongTienSTK);
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("\nDANH SACH CAC SACH GIAO KHOA CUA NHA XUAT BAN X LA:");
                            foreach (SachGiaoKhoa sgk in dsSachGiaoKhoa)
                            {
                                if (sgk.IsMatch("X") == true)
                                    sgk.Output();
                            }
                            break;
                        }
                    case 8:
                        {
                            List<NXB> stkNhieuNhat = new List<NXB>();
                            var dsTam = dsSachThamKhao.GroupBy(stk => stk.NhaXuatBan);
                            foreach (var nxb in dsTam)
                            {
                                var temp = 0;
                                foreach (var sl in nxb)
                                {
                                    temp += sl.SoLuong;
                                }
                                stkNhieuNhat.Add(new NXB(){ tenNXB = nxb.Key, soLuongSach = temp });
                                
                            }
                            stkNhieuNhat.Sort();
                            stkNhieuNhat.Reverse();
                            Console.WriteLine("\nNXB CO NHIEU TONG SO SACH THAM KHAO NHAT: " + stkNhieuNhat[0].tenNXB);
                            Console.WriteLine("TONG SO LUONG SACH CUA NXB: " + stkNhieuNhat[0].soLuongSach);
                            break;
                        }
                    case 9:
                        {
                            Console.Write("\nHAY NHAP MA SACH: ");
                            string maSachNhap = Console.ReadLine();
                            double thanhTienNhap = 0;
                            foreach (SachGiaoKhoa sgk in dsSachGiaoKhoa)
                            {
                                if (sgk.MaSach.ToLower() == maSachNhap.ToLower())
                                {
                                    if (sgk.TinhTrang.ToLower() == "moi")
                                    {
                                        thanhTienNhap += sgk.SoLuong * sgk.DonGia;
                                    }
                                    else
                                    {
                                        thanhTienNhap += sgk.SoLuong * sgk.DonGia * 0.5;
                                    }
                                }
                            }
                            foreach (SachThamKhao stk in dsSachThamKhao)
                            {
                                if (stk.MaSach.ToLower() == maSachNhap.ToLower())
                                    {
                                        thanhTienNhap += stk.SoLuong * stk.DonGia + stk.Thue;
                                    }
                            }
                            if (thanhTienNhap > 0)
                            {
                                Console.WriteLine("\nTONG THANH TIEN CUA MA SACH VUA NHAP LA: " + thanhTienNhap);
                            }
                            else
                            {
                                Console.WriteLine("\nKHONG CO SACH CO MA VUA NHAP!!!");
                            }
                            break;
                        }
                    default: break;
                }
            } while (option != 0);
            Console.ReadLine();
        }
    }
}