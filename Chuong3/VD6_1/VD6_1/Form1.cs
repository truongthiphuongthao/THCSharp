using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD6_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            // so sánh hai chuỗi với nhau có phân biệt hoa vs thường
            // lấy chuỗi thứ nhất
            string str1 = this.txbChuoi1.Text;
            string str2 = this.txbChuoi2.Text;
            int kq = string.Compare(str1, str2, false);
            this.txbKQ.Text += "Chuỗi thứ nhất ";
            if(kq == -1)
            {
                this.txbKQ.Text += " < ";
            }
            else if(kq == 0)
            {
                this.txbKQ.Text += " = ";
            }
            else
            {
                this.txbKQ.Text += " > ";
            }
            this.txbKQ.Text += "Chuỗi thứ hai ";

        }

        private void btnCompareIn_Click(object sender, EventArgs e)
        {
            // không phân biệt hoa thường
            string str1 = this.txbChuoi1.Text;
            string str2 = this.txbChuoi2.Text;

            int kq = String.Compare(str1, str2, true);
            this.txbKQ.Text += "Chuỗi thứ 1 ";
            if (kq == -1)
            {
                this.txbKQ.Text += " < ";
            }
            else if (kq == 0)
            {
                this.txbKQ.Text += " = ";
            }
            else this.txbKQ.Text += " > ";
            this.txbKQ.Text += "Chuỗi thứ 2 ";

        }

        private void btnConcat_Click(object sender, EventArgs e)
        {
            string str1 = this.txbChuoi1.Text;
            string str2 = this.txbChuoi2.Text;
            string str = String.Concat(str1, str2);
            this.txbKQ.Text += str;
        }

        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            string str1 = this.txbChuoi1.Text;
            string str2 = this.txbChuoi2.Text;
            // Chỉ ra vị trí xuất hiện của chuỗi 2 trong chuỗi 1
            if (str1.IndexOf(str2) >= 0)
            {
                this.txbKQ.Text = "Chuỗi 2 xuất hiện trong chuỗi 1 ở vị trí";
                this.txbKQ.Text += str1.IndexOf(str2);
                this.txbKQ.Text += ".!";
                // Thay thế chuỗi s="CHỖ NÀY" vào vị trí chuỗi 2 trong chuỗi 1
                string s = "CHỖ NÀY";
                this.txbKQ.Text += "\n\r Thay thế chuỗi thứ 2 trong chuỗi 1 bằng chuỗi CHỖ NÀY, ";
                this.txbKQ.Text += "\n\r Kết quả:" + str1.Replace(str2, s);
            }

            else this.txbKQ.Text = "Chuỗi 2 không xuất hiện trong chuỗi 1!";

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string str1 = this.txbChuoi1.Text;
            string str2 = this.txbChuoi2.Text;
            // Chèn chuỗi 2 vào sau từ đầu tiên của chuỗi 1
            this.txbKQ.Text = "Chèn chuỗi 2 vào sau từ đầu tiên của chuỗi 1: \n\r";
            this.txbKQ.Text += str1.Insert(str1.IndexOf(" "), str2);
            // Chèn chuỗi 2 vào trước từ cuối cùng của chuỗi 1
            this.txbKQ.AppendText ("\nChèn chuỗi 2 vào trước từ cuối cùng của chuỗi 1: \n\r");
            this.txbKQ.AppendText( str1.Insert(str1.LastIndexOf(" "), str2));
        }

        private void btnSubstring_Click(object sender, EventArgs e)
        {
            string s = "TRÌNH XỬ LÝ";
            int ix;
            ix = this.lbTieuDe.Text.IndexOf(s);
            if(ix >= 0)
            {
                this.txbKQ.Text = this.lbTieuDe.Text.Substring(ix, s.Length);
                this.txbKQ.Text += " xuất hiện trong tiêu đề tại vị trí ";
                this.txbKQ.Text += ix;
                // xóa s ra khoi tieu đề
                this.txbKQ.Text += "\n\rTiêu đề sau khi xóa " + s;
                this.txbKQ.Text += "\n\r Kết quả là: ";
                this.txbKQ.Text += this.lbTieuDe.Text.Remove(ix, s.Length);
            }
            else
            {
                this.txbKQ.Text = "Không xuất hiện trong chuỗi 1!";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txbChuoi1.ResetText();
            this.txbChuoi2.ResetText();
            this.txbKQ.Text = "";
            this.txbChuoi1.Focus();
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
