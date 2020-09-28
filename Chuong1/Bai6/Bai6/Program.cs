using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            // nhap 3 so nguyen, in ra so nguyen nho nhat
            string so1, so2, so3;
            Console.Write("nhap so nguyen thu nhat:");
            so1 = Console.ReadLine();
            Console.Write("nhap so nguyen thu hai:");
            so2 = Console.ReadLine();
            Console.Write("nhap so nguyen thu ba:");
            so3 = Console.ReadLine();
            // chuyen so nguyen thanh int
            int n_so1, n_so2, n_so3;
            n_so1 = Convert.ToInt32(so1);
            n_so2 = Convert.ToInt32(so2);
            n_so3 = Convert.ToInt32(so3);
            int tam = n_so1;
            if(tam >= n_so2)
            {
                tam = n_so2;
            }
            if(tam >= n_so3)
            {
                tam = n_so3;
            }
            Console.WriteLine("So nho nhat: {0}", tam);
            Console.ReadLine();
        }
    }
}
