using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai14
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            Console.Write("n=");
            n = Console.ReadLine();
            int n_n = Convert.ToInt32(n);
            int tong = 0;
            double tbc;
            for(int i=1; i <= n_n; i++)
            {
                tong += i;
                Console.Write("{0} ", i);
            }
            tbc = (double)(tong / n_n);
            Console.Write("\ntong: {0}", tong);
            Console.Write("\ntbc: {0: 0.0} ", tbc);
            Console.ReadLine();
        }
    }
}
