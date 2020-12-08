using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD7_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHoanDoi_Click(object sender, EventArgs e)
        {
            int a = int.Parse(this.txbA.Text);
            int b = int.Parse(this.txbB.Text);
            HoanDoi s = new HoanDoi();
            s.HoanVi(ref a, ref b);
            this.txbA.Text = a.ToString();
            this.txbB.Text = b.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txbA.ResetText();
            this.txbB.ResetText();
            this.txbA.Focus();

        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
