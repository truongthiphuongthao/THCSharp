using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            // giai phuong trinh bac 1 bx + c = 0
            string b, c;
            Console.Write("He so b:");
            b = Console.ReadLine();
            Console.Write("He so c:");
            c = Console.ReadLine();
            double n_b, n_c;
            n_b = Convert.ToDouble(b);
            n_c = Convert.ToDouble(c);
            if (n_b == 0)
            {
                if(n_c == 0)
                {
                    Console.Write("Vo so nghiem");
                }
                else
                {
                    Console.Write("Vo nghiem");
                }
            }
            else
            {
                Console.Write("Nghiem cua phuong trinh: {0:0.00}", -n_c / n_b);
            }

            Console.ReadLine();

        }
    }
}
