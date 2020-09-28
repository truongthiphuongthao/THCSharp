using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            // tinh chu vi, dien tich hinh chu nhat
            string cdai, crong;
            System.Console.WriteLine("Nhap chieu dai:");
            cdai = Console.ReadLine();
            System.Console.WriteLine("Nhap chieu rong:");
            crong = Console.ReadLine();
            double n_cdai, n_crong, cv, dt;
            n_cdai = System.Convert.ToDouble(cdai);
            n_crong = System.Convert.ToDouble(crong);
            cv = (n_cdai + n_crong) * 2;
            System.Console.WriteLine("Chu vi: {0:0.00}", cv);
            dt = (n_cdai * n_crong);
            System.Console.WriteLine("Dien tich: {0:0.00}", dt);
            Console.ReadLine();

        }
    }
}
