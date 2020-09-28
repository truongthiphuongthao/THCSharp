using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            // so chan so le
            int n;
            Console.Write("Nhap so n: ");
            string number;
            number = Console.ReadLine();
            n = System.Convert.ToInt32(number);
            if(n % 2 == 0 && n>=0)
            {
                System.Console.WriteLine("{0} la so chan, so duong", n);
            }
            else if(n % 2 != 0 && n>=0)
            {
                System.Console.WriteLine("{0} la so le, so duong", n);
            }
            else
            {
                System.Console.WriteLine("{0} la so am", n);
            }
            Console.ReadLine();
 
        }
       }
 }
