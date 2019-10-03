using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{

    class SinhVien
    {
        public static List<SinhVien> listSinhVien = new List<SinhVien>();

        public string mssv;
        public string tenSinhVien;
        public string khoa;
        public double diemTB;

        public SinhVien()
        {

        }

        public SinhVien(string maso, string ten, string k, double dtb)
        {
            mssv = maso;
            tenSinhVien = ten;
            khoa = k;
            diemTB = dtb;
        }
    }
}
