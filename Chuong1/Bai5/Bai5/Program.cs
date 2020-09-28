using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            string bacluong, ngaycong, phucap;
            System.Console.WriteLine("nhap bac luong:");
            bacluong = System.Console.ReadLine();
            System.Console.WriteLine("nhap ngay cong:");
            ngaycong = System.Console.ReadLine();
            System.Console.WriteLine("nhap phu cap:");
            phucap = System.Console.ReadLine();
            int n_ngaycong, n_phucap;
            n_ngaycong = System.Convert.ToInt32(ngaycong);
            double nctl, tienlanh, n_bacluong;
            n_bacluong = System.Convert.ToDouble(bacluong);
            n_phucap = System.Convert.ToInt32(phucap);
            const int heso = 650000;
            // tinh ngay cong
            if(n_ngaycong >= 25)
            {
                nctl = (n_ngaycong - 25) * 2 + 25;
            }
            else
            {
                nctl = n_ngaycong;
            }
            // tinh tien lanh
            tienlanh = n_bacluong * heso * nctl + n_phucap;
            System.Console.WriteLine("Tien lanh: {0:0.00}", tienlanh);
            Console.ReadLine();
        }
    }
}
