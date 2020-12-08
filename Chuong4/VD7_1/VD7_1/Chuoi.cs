using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD7_1
{
    public class Chuoi
    {
        string tenchuongtrinh = "Chương trình xử lý họ và tên";
        // phuong thuc
        public string In()
        {
            return tenchuongtrinh;
        }

        // lấy tên
        public string Ten(string hoten)
        {
            int lio = hoten.LastIndexOf(" ");
            return hoten.Substring(lio + 1, hoten.Length - lio - 1);
        }

        // lấy họ lót
        public string HoLot(string hoten)
        {
            int lio = hoten.LastIndexOf(" ");
            return hoten.Substring(0, lio);
        }
        // đếm sô từ trong chuỗi
        public int CountOfWord(string hoten)
        {
            int i, dem = 1;
            for(i=0; i<hoten.Length; i++)
            {
                if(hoten[i].ToString() == " ")
                {
                    dem++;
                }
            }
            return dem;
        }

        // Đổi chữ hoa hoa đầu từ

        public string Proper(string hoten)
        {
            string s = hoten.Trim();
            string kq = "";
            if(s.Length == 0)
            {
                kq = "Chuỗi rỗng!";
            }
            else
            {
                kq = s.Substring(0, 1).ToUpper();
                for(int i = 1; i < s.Length; i++)
                {
                    if ((s[i].ToString() != " ") && (s[i - 1].ToString() == " "))
                    {
                        string ss = s[i].ToString();
                        kq += ss.ToUpper();
                    }
                    else kq += s[i].ToString();
                }
            }
            return kq;
        }

        // in hoa
        public string Upper(string hoten)
        {
            string s = hoten.Trim();
            string kq = "";
            int i;
            for (i = 0; i < hoten.Length; i++)
            {
                if(hoten[i]>=97 && hoten[i] <= 122)
                {
                    char x = (char)(hoten[i] - 32);
                    kq += x;
                }
                else
                {
                    kq += hoten[i].ToString();
                }
            }
            return kq;
        }

        // in thường
        public string Lower(string hoten)
        {
            string s = hoten.Trim();
            string kq = "";
            int i;
            for (i = 0; i < hoten.Length; i++)
            {
                if (hoten[i] >= 65 && hoten[i] <=90)
                {
                    char x = (char)(hoten[i] + 32);
                    kq += x;
                }
                else
                {
                    kq += hoten[i].ToString();
                }
            }
            return kq;
        }
    }
}
