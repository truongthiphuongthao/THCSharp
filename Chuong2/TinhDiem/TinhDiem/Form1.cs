using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhDiem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            string diemVan, diemToan, diemNN;
            diemVan = this.txtDiemVan.Text;
            diemToan = this.txtDiemToan.Text;
            diemNN = this.txtDiemNgoaiNgu.Text;
            // in ra điểm thấp nhất
            double n_diemVan = Convert.ToDouble(diemVan);
            double n_diemToan = Convert.ToDouble(diemToan);
            double n_diemNN = Convert.ToDouble(diemNN);
            double tmp = n_diemVan;
            if(tmp > n_diemToan)
            {
                tmp = n_diemToan;
            }
            if( tmp > n_diemNN)
            {
                tmp = n_diemNN;
            }

            txtDiemTN.AppendText(tmp.ToString());
            // Điểm thêm
            // 0.5 cho nữ và 0 cho nam
            double diemThem, diemKQ;
            if (chkNu.Checked == true)
            {
                diemThem = 0.5;
               
            }
            else
            {
                diemThem = 0;
            }
            // Tính điểm kết quả
            // txtKQ = txtVan * 2 + txtToan * 2 + txtNN + DThem
            diemKQ = Math.Round(n_diemVan * 2 + n_diemToan * 2 + n_diemNN + diemThem, 2);
            txtDiemKQ.AppendText(diemKQ.ToString());
            // Xếp loại
            //  Giỏi: nếu txtKQ >= 40 và txtDTN >= 7
             if (diemKQ >= 40 && tmp >= 7)
            {
                txtXepLoai.AppendText("Giỏi");
            }
            // Khá: nếu txtKQ >=35 và txtDTN >= 6
            else if (diemKQ >= 35 && tmp >= 6)
            {
                txtXepLoai.AppendText("Khá");
            }
            // trung bình nếu txtKQ >= 25 và txtDTN >= 5
            if (diemKQ >= 25 && tmp >= 5)
            {
                  txtXepLoai.AppendText("Trung Bình");
            }
            // Xếp loại yếu
            else
            {
                  txtXepLoai.AppendText("Yếu");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtHoTen.Clear();
            chkNu.Checked = false;
            this.txtDiemVan.Clear();
            this.txtDiemToan.Clear();
            this.txtDiemNgoaiNgu.Clear();
            this.txtDiemTN.Clear();
            this.txtDiemKQ.Clear();
            this.txtXepLoai.Clear();

        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không", "Bạn có muốn thoát ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }
    }
}
