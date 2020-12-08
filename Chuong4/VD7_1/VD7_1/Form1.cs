using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD7_1
{
    public partial class Form1 : Form
    {
        Chuoi s = new Chuoi();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInLoiGioiThieu_Click(object sender, EventArgs e)
        {
            this.txbKQ.Text = s.In();
        }

        private void btnHoLot_Click(object sender, EventArgs e)
        {
            this.txbKQ.Text = "Họ lót: " + s.HoLot(this.txbHoTen.Text)+ Environment.NewLine;
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            this.txbKQ.Text = "Tên: " + s.Ten(this.txbHoTen.Text) + Environment.NewLine;
        }

        private void btnDemTu_Click(object sender, EventArgs e)
        {
            this.txbKQ.Text += "Tổng số từ là: ";
            this.txbKQ.Text += s.CountOfWord(this.txbHoTen.Text)+ Environment.NewLine;
        }

        private void btnHoaDauTu_Click(object sender, EventArgs e)
        {
            this.txbKQ.Text += "Kết quả là: ";
            this.txbKQ.Text += s.Proper(this.txbHoTen.Text) + Environment.NewLine;
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txbHoTen.Clear();
            this.txbKQ.Clear();
            this.txbHoTen.Focus();
        }

        private void btnInHoa_Click(object sender, EventArgs e)
        {
            this.txbKQ.Text += "Kết quả là: ";
            this.txbKQ.Text += s.Upper(this.txbHoTen.Text) + Environment.NewLine;
        }

        private void btnInThuong_Click(object sender, EventArgs e)
        {
            this.txbKQ.Text += "Kết quả là: ";
            this.txbKQ.Text += s.Lower(this.txbHoTen.Text) + Environment.NewLine;
        }
    }
}
