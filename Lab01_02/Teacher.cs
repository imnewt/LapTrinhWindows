using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    class Teacher : Person
    {
        private string diaChi;

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public Teacher()
        {

        }

        public Teacher(string id, string hoTen, string diaChi)
        {
            this.id = id;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
        }

        public override void Input()
        {
            Console.WriteLine();
            Console.WriteLine("== NHAP THONG TIN GIAO VIEN ==");
            base.Input();
            Console.Write("DIA CHI: ");
            this.diaChi = Console.ReadLine();
        }

        public override void Output()
        {
            Console.WriteLine();
            Console.WriteLine("== THONG TIN GIANG VIEN ==");
            base.Output();
            Console.WriteLine("DIA CHI: {0}", this.DiaChi);
        }
    }
}