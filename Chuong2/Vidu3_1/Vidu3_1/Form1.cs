using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vidu3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string thongbao;
            thongbao = "Tên đăng nhập là: ";
            thongbao += this.txtTenDangNhap.Text;
            thongbao += "\n\rMật khẩu là: ";
            thongbao += this.txtMatKhau.Text;
            if(chkGhiNho.Checked == true)
            {
                thongbao += "\n\r Bạn có ghi nhớ";
            }
            MessageBox.Show(thongbao, "Thông báo");

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtTenDangNhap.ResetText();
            this.txtMatKhau.ResetText();
            this.txtTenDangNhap.Focus();
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(traloi == DialogResult.OK)
                Application.Exit();
        }
    }
}
