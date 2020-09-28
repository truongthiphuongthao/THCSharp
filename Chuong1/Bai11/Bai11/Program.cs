using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bai11
{
    class Program
    {
        static void Main(string[] args)
        {
            // so nguyen to
            string n;
            Console.Write("Nhap n:");
            n = Console.ReadLine();
            int n_n;
            n_n = Convert.ToInt32(n);
            int check = 1;
            for(int i=2; i<= (n_n/2); i++)
            {
                if(n_n % i == 0)
                {
                    check = 0;
                }
            }
            if(check == 1)
            {
                Console.WriteLine("so nguyen to");
            }
            else
            {
                Console.WriteLine("khong phai so nguyen to");
            }
            Console.ReadLine();
        }
    }
}
