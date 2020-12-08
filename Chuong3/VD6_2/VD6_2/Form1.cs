using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD6_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            // Đếm số từ trong chuỗi
            string str = this.txbHoTen.Text;
            int count = 1;
            for(int i = 0; i < str.Length; i++)
            {
                if(str[i]== ' ')
                {
                    count += 1;
                }
            }
            this.txbKQ.Text += count + "";
        }

        private void btnProper_Click(object sender, EventArgs e)
        {
            // Đổi chữ hoa đầu từ trong chuỗi họ tên
            string s = this.txbHoTen.Text.Trim();
            // In hoa từ đầu tiên
            if(s.Length == 0)
            {
                MessageBox.Show("Chuỗi rỗng!");
            }
            else
            {
                this.txbKQ.Text = s.Substring(0, 1).ToUpper();
                for (int i = 1; i < s.Length; i++)
                {
                    if ((s[i].ToString() != " ") && (s[i - 1].ToString() == " "))
                    {
                        string ss = s[i].ToString();
                        this.txbKQ.Text += ss.ToUpper();
                    }
                    else
                    {
                        this.txbKQ.Text += s[i].ToString();
                    }
                }
            } 
            // Đổi chữ hoa thành chữ thường trong chuỗi
         /*   string chuoi="";
            for(int i=0; i < s.Length; i++)
            {
                if(s[i]>=65 && s[i] <= 90)
                {
                    char x = (char)(s[i] + 32);
                     chuoi += x.ToString();
                }
                else
                {
                    chuoi += s[i].ToString();
                }
            }
            this.txbKQ.Text += chuoi + ""; */
           
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            string s = this.txbHoTen.Text.Trim();
            if(s.Length == 0)
            {
                MessageBox.Show("Chuỗi rỗng");
            }
            else
            {
                // Lấy từ từ bên trái
                this.txbKQ.Text = "Từ đầu tiên của chuỗi là: ";
                // Dùng hàm
                // this.txbKQ.Text += s.Substring(0, s.IndexOf(" "));
                int vt = 0;
               for(int i=0; i < s.Length; i++)
               {
                    if(s[i].ToString() == " ")
                    {
                        vt = i;
                        break;
                    }
               }
               for(int j=0; j < vt; j++)
                {
                    this.txbKQ.Text += s[j].ToString();
                }
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            string s = this.txbHoTen.Text.Trim();
            if (s.Length == 0)
                this.txbKQ.Text = "Chuỗi rỗng!";
            else
            {
                this.txbKQ.Text = "Từ đầu tiên của chuỗi là: ";
                // dung ham
                //this.txbKQ.Text += s.Substring(s.LastIndexOf(" ") + 1,
                //s.Length - s.LastIndexOf(" ") - 1);
                int vt = 0;
                for (int i = s.Length-1; i >=0; i--)
                {
                    if (s[i].ToString() == " ")
                    {
                        vt = i;
                        break;
                    }
                }
                for (int j = vt; j <s.Length; j++)
                {
                    this.txbKQ.Text += s[j].ToString();
                }

            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txbHoTen.Clear();
            this.txbKQ.Clear();
            this.txbHoTen.Focus();
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
