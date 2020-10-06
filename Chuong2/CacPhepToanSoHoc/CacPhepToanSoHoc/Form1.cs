using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CacPhepToanSoHoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            string sothu1 = txtSoThu1.Text;
            string sothu2 = txtSoThu2.Text;
            double ketqua;
            ketqua = Convert.ToDouble(sothu1) + Convert.ToDouble(sothu2);
            txtKetQua.AppendText(ketqua+"");
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            string sothu1 = txtSoThu1.Text;
            string sothu2 = txtSoThu2.Text;
            double ketqua;
            ketqua = Convert.ToDouble(sothu1) - Convert.ToDouble(sothu2);
            txtKetQua.AppendText(ketqua + "");
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            string sothu1 = txtSoThu1.Text;
            string sothu2 = txtSoThu2.Text;
            double ketqua;
            ketqua = Convert.ToDouble(sothu1) * Convert.ToDouble(sothu2);
            txtKetQua.AppendText(ketqua + "");
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            string sothu1 = txtSoThu1.Text;
            string sothu2 = txtSoThu2.Text;
            if(sothu2 == "0")
            {
                MessageBox.Show("Thông báo lỗi");
                this.txtSoThu2.Clear();
                this.txtSoThu2.Focus();
            }
            else
            {
                double ketqua;
                ketqua = Convert.ToDouble(sothu1) / Convert.ToDouble(sothu2);
                txtKetQua.AppendText(ketqua + "");
            }
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtSoThu1.Clear();
            this.txtSoThu2.Clear();
            this.txtKetQua.Clear();
            this.txtSoThu1.Focus();
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
