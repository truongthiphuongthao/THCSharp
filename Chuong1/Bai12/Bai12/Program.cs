using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12
{
    class Program
    {
        static void Main(string[] args)
        {
            // cho biet nam nhuan
            string nam;
            Console.WriteLine("Nhap vao nam nhuan:");
            nam = Console.ReadLine();
            int n_nam;
            n_nam = Convert.ToInt32(nam);
            if((n_nam %400 == 0 ) || (n_nam %4 ==0 && n_nam % 100 != 0))
            {
                Console.WriteLine("Nam nhuan");
            }
            else
            {
                Console.WriteLine("Nam khong nhuan");
            }
            Console.ReadLine();
        }
    }
}
