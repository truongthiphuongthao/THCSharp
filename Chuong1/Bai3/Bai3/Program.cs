using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            // tinh dien tich, chu vi hinh vuong
            string canh;
            System.Console.WriteLine("Nhap canh hinh vuong:");
            canh = System.Console.ReadLine();
            double n_canh, cv, dt;
            n_canh = System.Convert.ToDouble(canh);
            cv = n_canh * 4;
            System.Console.WriteLine("Chu vi hinh vuong: {0:0.00}", cv);
            dt = n_canh * n_canh;
            System.Console.WriteLine("Dien tich hinh vuong: {0:0.00}", dt);
            Console.ReadLine();

        }
    }
}
