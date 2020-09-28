using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            // nhap vao ho ten
            string hoten;
            System.Console.WriteLine("Nhap vao ho ten:");
            hoten = System.Console.ReadLine();
            // nhap vao diem toan, ly, hoa
            string diemtoan, diemly, diemhoa;
            System.Console.WriteLine("Nhap diem toan:");
            diemtoan = System.Console.ReadLine();
            System.Console.WriteLine("Nhap diem ly:");
            diemly = System.Console.ReadLine();
            System.Console.WriteLine("Nhap diem hoa:");
            diemhoa = System.Console.ReadLine();
            // doi diem toan, ly, hoa thanh so thuc
            double n_diemtoan, n_diemly, n_diemhoa, dtb;
            n_diemtoan = System.Convert.ToDouble(diemtoan);
            n_diemly = System.Convert.ToDouble(diemly);
            n_diemhoa = System.Convert.ToDouble(diemhoa);
            // tinh diem tb
            dtb = (n_diemtoan + n_diemly + n_diemhoa) / 3;
            System.Console.WriteLine("Ho ten: {0}", hoten.ToUpper());
            System.Console.WriteLine("Diem tb: {0: 0.00}", dtb);
            Console.ReadLine();

        }
    }
}
