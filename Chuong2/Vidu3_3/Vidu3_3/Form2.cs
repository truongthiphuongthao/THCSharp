using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vidu3_3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (this.txtTenNguoiDung.Text == "thao" && this.txtMatKhau.Text == "123")
            {
                Form form1 = new Form1();
                form1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không đúng tên người dùng / mật khẩu !!!", "Thông báo");
                this.txtTenNguoiDung.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(traloi == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
