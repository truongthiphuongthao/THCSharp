using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_Chuong3
{
   public class Bai1
    {
        // hàm lấy tên
        public string LayTen(string hoten)
        {
            string s = hoten.Trim();
            int index = s.LastIndexOf(" ");
            string ten = s.Substring(index + 1, s.Length - index - 1);
            return ten;
        }
        // hàm kiểm tra số nguyên tố
        public bool KTSNT(int snt)
        { 
            if(snt < 2)
            {
                return false;
            }
            else
            {
                for(int i=2;i<=Math.Sqrt(snt); i++)
                {
                    if (snt % i == 0) return false;
                }
            }
            return true;
        }
    }
}
