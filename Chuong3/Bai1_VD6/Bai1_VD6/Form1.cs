using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_VD6
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDoDai_Click(object sender, EventArgs e)
        {
            string hoten = this.txbHoTen.Text.Trim();
            int dodai = hoten.Length;
            int i, dem = 1;
            if(hoten.Length == 0)
            {
                this.txbKQ.Text += "Chuỗi rỗng!";   
            }
            else
            {
                for (i = 0; i < dodai; i++)
                {
                    if (hoten[i].ToString() == " ")
                    {
                        dem++;
                    }
                }
                this.txbKQ.Text += "Độ dài: " + dodai.ToString() + "\nSố từ: " + dem.ToString();
            }
           
        }

        private void btnChuThuong_Click(object sender, EventArgs e)
        {
            string hoten = this.txbHoTen.Text.Trim();
            if (hoten.Length == 0)
            {
                this.txbKQ.Text += "Chuỗi rỗng!";
            }
            else
            {
                for (int i = 0; i < hoten.Length; i++)
                {
                    string ss = hoten[i].ToString();
                    this.txbKQ.Text += ss.ToLower();
                }
            }
            
        }

        private void btnInHoa_Click(object sender, EventArgs e)
        {
            string hoten = this.txbHoTen.Text.Trim();
            if (hoten.Length == 0)
            {
                this.txbKQ.Text += "Chuỗi rỗng!";
            }
            else
            {
                for (int i = 0; i < hoten.Length; i++)
                {
                    string ss = hoten[i].ToString();
                    this.txbKQ.Text += ss.ToUpper();
                }
            }
            
        }

        private void btnVietHoaDauTu_Click(object sender, EventArgs e)
        {
            string hoten = this.txbHoTen.Text.Trim();
            if (hoten.Length == 0)
            {
                this.txbKQ.Text += "Chuỗi rỗng!";
            }
            else
            {
                this.txbKQ.Text += hoten.Substring(0, 1).ToUpper();
                for (int i = 1; i < hoten.Length; i++)
                {
                    if ((hoten[i - 1].ToString() == " ") && (hoten[i].ToString() != " "))
                    {
                        string ss = hoten[i].ToString();
                        this.txbKQ.Text += ss.ToUpper();
                    }
                    else
                    {
                        this.txbKQ.Text += hoten[i].ToString();
                    }
                }
            }
           
        }

        private void btnLoaiBoKhoangTrangThua_Click(object sender, EventArgs e)
        {
            // xóa bỏ khoang trắng thừa ở đầu và cuối chuỗi
            string hoten = this.txbHoTen.Text.Trim();
            if (hoten.Length == 0)
            {
                this.txbKQ.Text += "Chuỗi rỗng!";
            }
            else
            {
                // Dùng regex xóa khoảng trắng bên trong chuỗi
                Regex trimmer = new Regex(@"\s\s+");
                hoten = trimmer.Replace(hoten, " ");
                this.txbKQ.Text += hoten.ToString();
            }
        }
    }
}
