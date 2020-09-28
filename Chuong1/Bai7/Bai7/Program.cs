using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            // nhap ho ten
            string hoten;
            Console.Write("Nhap ho ten:");
            hoten = Console.ReadLine();
            // nhap diem
            string diem;
            Console.Write("Nhap diem:");
            diem = Console.ReadLine();
            // chuyen diem thanh double
            double n_diem;
            n_diem = Convert.ToDouble(diem);
            if(n_diem < 5)
            {
                Console.Write("Ho ten :{0}", hoten.ToUpper());
                Console.Write("\nYeu");
            }
            else if(n_diem >= 5 && n_diem < 6.5)
            {
                Console.Write("Ho ten :{0}", hoten.ToUpper());
                Console.Write("\nTrung binh");
            }
            else if(n_diem >= 6.5 && n_diem < 8)
            {
                Console.Write("Ho ten :{0}", hoten.ToUpper());
                Console.Write("\nKha");
            }
            else
            {
                Console.Write("Ho ten :{0}", hoten.ToUpper());
                Console.Write("\nGioi");
            }

            Console.ReadLine();

        }
    }
}
