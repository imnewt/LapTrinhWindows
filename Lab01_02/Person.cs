using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    class Person
    {
        protected string id;
        protected string hoTen;

        public string ID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string HoTen
        {
            get
            {
                return hoTen;
            }

            set
            {
                hoTen = value;
            }
        }

        public virtual void Input()
        {
            Console.Write("ID: ");
            this.id = Console.ReadLine();
            Console.Write("HO TEN: ");
            this.hoTen = Console.ReadLine();
        }

        public virtual void Output()
        {
            Console.WriteLine("ID: {0}", this.id);
            Console.WriteLine("HO TEN: {0}", this.hoTen);
        }
    }
}