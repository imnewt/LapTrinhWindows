using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    class Tester
    {
        static void Main(string[] args)
        {
            Console.Write("NHAP SO NGUOI: ");

            int n = Convert.ToInt32(Console.ReadLine());

            List<Person> listPerson = new List<Person>();
            List<Student> listStudent = new List<Student>();
            List<Teacher> listTeacher = new List<Teacher>();

            byte option = 9;

            while (option != 0)
            {
                Console.WriteLine();
                Console.WriteLine("1. NHAP THONG TIN CHO SINH VIEN");
                Console.WriteLine("2. NHAP THONG TIN CHO GIAO VIEN");
                Console.WriteLine("3. XUAT THONG TIN CAC HOC SINH");
                Console.WriteLine("4. XUAT THONG TIN CAC GIAO VIEN");
                Console.WriteLine("5. TIM SINH VIEN CO DIEM CAO NHAT THUOC KHOA CNTT");
                Console.WriteLine("6. TIM KIEM THONG TIN THEO TEN");
                Console.WriteLine("0. LUU VA THOAT");
                Console.Write("> ");
                option = Convert.ToByte(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            if (listPerson.Count() == n)
                            {
                                Console.Write("\nSO LUONG NGUOI DA TOI DA! VUI LONG NHAP LUA CHON KHAC..\n");
                                break;
                            }
                            Student sv = new Student();
                            sv.Input();
                            listStudent.Add(sv);
                            listPerson.Add(sv);
                            break;
                        }
                    case 2:
                        {
                            if (listPerson.Count() == n)
                            {
                                Console.Write("\nSO LUONG NGUOI DA TOI DA! VUI LONG NHAP LUA CHON KHAC..\n");
                                break;
                            }
                            Teacher tc = new Teacher();
                            tc.Input();
                            listTeacher.Add(tc);
                            listPerson.Add(tc);
                            break;
                        }
                    case 3:
                        {
                            foreach (Student sv in listStudent)
                            {
                                sv.Output();
                            }
                            break;
                        }
                    case 4:
                        {
                            foreach (Teacher tc in listTeacher)
                            {
                                tc.Output();
                            }
                            break;
                        }
                    case 5:
                        {
                            List<Student> listSVKhoaCNTT = listStudent.Where(sv => sv.Khoa.ToLower() == "cntt").ToList();
                            float maxScore = listSVKhoaCNTT.Max(p => p.DiemTrungBinh);
                            Console.WriteLine("\n== DANH SACH SINH VIEN CO DTB CAO NHAT VA THUOC KHOA CNTT ==");
                            foreach (Student sv in listSVKhoaCNTT)
                            {
                                if (sv.DiemTrungBinh == maxScore)
                                    sv.Output();
                            }
                            break;
                        }
                    case 6:
                        {
                            Console.Write("\nHAY NHAP TEN CAN TIM KIEM: ");
                            string inputName = Console.ReadLine();
                            Person find = listPerson.FirstOrDefault(p => p.HoTen == inputName.ToLower());
                            Console.WriteLine("\n== DANH SACH TIM KIEM THEO TEN VUA NHAP ==");
                            find.Output();
                            break;
                        }
                    default: break;

                }
            }
            Console.ReadLine();
        }
    }
}