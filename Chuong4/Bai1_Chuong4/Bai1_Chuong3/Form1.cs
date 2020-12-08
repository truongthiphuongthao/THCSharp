using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_Chuong3
{
    public partial class Form1 : Form
    {
        Bai1 bai = new Bai1();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTen_Click(object sender, EventArgs e)
        {

            string ten = bai.LayTen(this.txbTen.Text);
            this.txbKQ.Text+= ten;
        }

        private void btnSoNguyenTo_Click(object sender, EventArgs e)
        {
            int snt = Convert.ToInt32(this.txbSoNguyenTo.Text);
            string res_snt = bai.KTSNT(snt).ToString();
            this.txbKQ.Text += res_snt;
        }
    }
}
