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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            string diemVan, diemToan, diemNgoaiNgu;
            diemVan = this.txtDiemVan.Text;
            diemToan = this.txtDiemToan.Text;
            diemNgoaiNgu = this.txtDiemNgoaiNgu.Text;
            double n_diemVan, n_diemToan, n_diemNgoaiNgu;
            n_diemVan = Convert.ToDouble(diemVan);
            n_diemToan = Convert.ToDouble(diemToan);
            n_diemNgoaiNgu = Convert.ToDouble(diemNgoaiNgu);
            double tmp;
            tmp = n_diemVan;
            if( tmp > n_diemToan)
            {
                tmp = n_diemToan;
            }
            if( tmp > n_diemNgoaiNgu)
            {
                tmp = n_diemNgoaiNgu;
            }
            txtDiemTN.AppendText(tmp.ToString());
            // tính điểm thêm
            double diemThem, diemKQ;
            if(chkNu.Checked == true)
            {
                diemThem = 0.5;
            }
            else
            {
                diemThem = 0;
            }
            // tính điểm kết quả
            //txtKQ = txtVan * 2 + txtToan * 2 + txtNN + DThem
            diemKQ = Math.Round(n_diemVan * 2 + n_diemToan * 2 + n_diemNgoaiNgu + diemThem, 2);
            txtDiemKQ.AppendText(diemKQ.ToString());
            // xếp loại
            if(diemKQ>= 40 && tmp >= 7)
            {
                txtXepLoai.AppendText("Giỏi");
            }
            else if (diemKQ >= 35 && tmp >= 6)
            {
                txtXepLoai.AppendText("Khá");
            }
            else if (diemKQ >= 25 && tmp >= 5)
            {
                txtXepLoai.AppendText("Trung bình");
            }
            else
            {
                txtXepLoai.AppendText("Yếu");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtHoTen.Clear();
            this.txtDiemVan.Clear();
            this.txtDiemToan.Clear();
            this.txtDiemNgoaiNgu.Clear();
            this.txtDiemKQ.Clear();
            this.txtDiemTN.Clear();
            this.txtXepLoai.Clear();
            this.txtHoTen.Focus();
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Bạn có muốn thoát ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if( traloi == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
