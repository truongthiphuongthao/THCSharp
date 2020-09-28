using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            // tinh phuong trinh bac 2 ax2 + bx + c = 0
            string a, b, c;
            Console.WriteLine("he so a:");
            a = Console.ReadLine();
            Console.WriteLine("he so b:");
            b = Console.ReadLine();
            Console.WriteLine("he so c:");
            c = Console.ReadLine();
            double number_a, number_b, number_c;
            number_a = Convert.ToDouble(a);
            number_b = Convert.ToDouble(b);
            number_c = Convert.ToDouble(c);
            // tinh denta
            double bb = number_b * number_b;

            double ac = 4 * (number_a * number_c);
            double denta = bb-ac ;
            double candenta = (Math.Sqrt(denta));
            if(denta < 0)
            {                                                                                                                                                                                                                                                   
                Console.WriteLine("Vo nghiem");
            }
            else if(denta == 0)
            {
                Console.WriteLine("Co nghiem kep: x1 = x2 = {0: 0.00}", -number_b/(2*number_a ));
            }
            else
            {
                Console.WriteLine("Co 2 nghiem phan biet: x1 = {0: 0.00}", (-number_b + candenta) / (2 * number_a));
                Console.WriteLine("Co 2 nghiem phan biet: x1 = {0: 0.00}", (-number_b - candenta) / (2 * number_a));
            }
            
            Console.ReadLine();
        }
    }
}
