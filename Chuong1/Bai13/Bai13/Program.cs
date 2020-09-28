using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            Console.Write("Nhap vao so nguyen:");
            n = Console.ReadLine();
            int n_n, sum = 0;
            n_n = Convert.ToInt16(n);
            for(int i =1; i<= n_n; i++)
            {
                sum +=  i;
            }
            Console.WriteLine("tong: {0}", sum);
            // tinh n1;
            string n1;
            Console.Write("Nhap vao so nguyen:");
            n1 = Console.ReadLine();
            int n_n1;
            double sum_1 = 0;
            n_n1 = Convert.ToInt16(n1);
            for (int i = 1; i <= n_n1; i++)
            {
                sum_1 = sum_1 + (1 /(double) i);
              
            }
            Console.WriteLine("tong1: {0: 0.00}", sum_1);
            Console.ReadLine();
        }
    }
}
