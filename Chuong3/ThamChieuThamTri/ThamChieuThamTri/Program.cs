using System;

namespace ThamChieuThamTri
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int min, max;
            min_max(a, b, out min, out max);
            Console.WriteLine(min + " " + max);
           /* swap(ref a, ref b);
            Console.WriteLine(a+" "+ b);*/
            
            
        }
       static void inc(out int a)
        {
            a = 5;
        }

        static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void min_max(int a, int b, out int mn, out int mx)
        {
            if (a < b)
            {
                mn = a;
                mx = b;
            }
            else
            {
                mn = b;
                mx = a;
            }
        }


    }
}
