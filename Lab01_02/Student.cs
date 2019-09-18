using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    class Student : Person
    {
        private float diemTrungBinh;
        private string khoa;

        public float DiemTrungBinh
        {
            get
            {
                return diemTrungBinh;
            }
            set
            {
                diemTrungBinh = value;
            }
        }
        public string Khoa
        {
            get
            {
                return khoa;
            }
            set
            {
                khoa = value;
            }
        }

        public Student()
        {

        }

        public Student(string id, string hoTen, float diemTrungBinh, string khoa)
        {
            this.id = id;
            this.hoTen = hoTen;
            this.diemTrungBinh = diemTrungBinh;
            this.khoa = khoa;
        }

        public override void Input()
        {
            Console.WriteLine();
            Console.WriteLine("== NHAP THONG TIN SINH VIEN ==");
            base.Input();
            Console.Write("DTB: ");
            this.DiemTrungBinh = float.Parse(Console.ReadLine());
            Console.Write("KHOA: ");
            this.Khoa = Console.ReadLine();
        }

        public override void Output()
        {
            Console.WriteLine();
            Console.WriteLine("== THONG TIN SINH VIEN ==");
            base.Output();
            Console.WriteLine("DTB: {0}", this.DiemTrungBinh);
            Console.WriteLine("KHOA: {0}", this.Khoa);
        }

    }
}