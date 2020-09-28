using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    class Program
    {
        static void Main(string[] args)
        {
            // nhap so nguyen cho den so nguyen duong thi dung
            string songuyen;
            Console.Write("Nhap so nguyen:");
            songuyen = Console.ReadLine();
            int n_songuyen;
            n_songuyen = Convert.ToInt32(songuyen);
            while(n_songuyen < 0)
            {
                Console.Write("Nhap so nguyen:");
                songuyen = Console.ReadLine();
                n_songuyen = Convert.ToInt32(songuyen);
            }

            Console.WriteLine("Ket thuc do co so duong");
            Console.ReadLine();
            
        }
    }
}
