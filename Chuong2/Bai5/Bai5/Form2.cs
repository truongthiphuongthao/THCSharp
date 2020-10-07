using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            string sothu1, sothu2;
            sothu1 = this.txtSo1.Text;
            sothu2 = this.txtSo2.Text;
            double n_sothu1, n_sothu2;
            n_sothu1 = Convert.ToDouble(sothu1);
            n_sothu2 = Convert.ToDouble(sothu2);
            double kq;
            kq = Math.Round((n_sothu1 + n_sothu2), 2);
            txtKQ.AppendText(kq.ToString());

        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            string sothu1, sothu2;
            sothu1 = this.txtSo1.Text;
            sothu2 = this.txtSo2.Text;
            double n_sothu1, n_sothu2;
            n_sothu1 = Convert.ToDouble(sothu1);
            n_sothu2 = Convert.ToDouble(sothu2);
            double kq;
            kq = Math.Round((n_sothu1 - n_sothu2), 2);
            txtKQ.AppendText(kq.ToString());
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            string sothu1, sothu2;
            sothu1 = this.txtSo1.Text;
            sothu2 = this.txtSo2.Text;
            double n_sothu1, n_sothu2;
            n_sothu1 = Convert.ToDouble(sothu1);
            n_sothu2 = Convert.ToDouble(sothu2);
            double kq;
            kq = Math.Round((n_sothu1 * n_sothu2), 2);
            txtKQ.AppendText(kq.ToString());
        }

        private void btnchia_Click(object sender, EventArgs e)
        {
            string sothu1, sothu2;
            sothu1 = this.txtSo1.Text;
            sothu2 = this.txtSo2.Text;
            double n_sothu1, n_sothu2;
            n_sothu1 = Convert.ToDouble(sothu1);
            n_sothu2 = Convert.ToDouble(sothu2);
            if(n_sothu2 == 0)
            {
                MessageBox.Show("Số phải lớn hơn 0");
                txtSo2.Clear();
                //txtKQ.Clear();
                txtSo2.Focus();
            }
            else
            {
                double kq;
                kq = Math.Round((n_sothu1 / n_sothu2), 2);
                txtKQ.AppendText(kq.ToString());
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtSo1.Clear();
            this.txtSo2.Clear();
            this.txtKQ.Clear();
            this.txtSo1.Focus();
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("\rBạn có muốn thoát ?","Trả lời",  MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if( traloi == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
            Form form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
