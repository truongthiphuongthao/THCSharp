using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD6_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            try
            {
                int sothunhat = int.Parse(this.txbSoThuNhat.Text);
                int sothuhai = int.Parse(this.txbSoThuHai.Text);
                this.txbThuong.Text += (float) sothunhat / sothuhai;
            }
            catch (Exception ex)
            {
                this.txbThuong.Text += "Lỗi rồi!";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txbThuong.Clear();
            this.txbSoThuNhat.Clear();
            this.txbSoThuHai.Clear();
            this.txbSoThuNhat.Focus();
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
