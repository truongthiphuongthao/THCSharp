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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            string a, b, c;
            a = this.txtA.Text;
            b = this.txtB.Text;
            c = this.txtC.Text;
            double n_a, n_b, n_c, nghiem, nghiem1, nghiem2, denta, candenta;
            n_a = Convert.ToDouble(a);
            n_b = Convert.ToDouble(b);
            n_c = Convert.ToDouble(c);
            denta = n_b * n_b - 4 * n_a * n_c;
            candenta = Math.Sqrt(denta);
            if( denta  < 0)
            {
                txtNghiem.AppendText("Vô Nghiệm");
            }
            else if( denta == 0)
            {
                nghiem = Math.Round(-n_b / (2 * n_a), 2);
                txtNghiem.AppendText(nghiem.ToString());
            }
            else
            {
                nghiem1 = Math.Round((-n_b + candenta) / (2 * n_a), 2);
                nghiem2 = Math.Round((-n_b - candenta) / (2 * n_a), 2);
                txtNghiem.AppendText(nghiem1.ToString()+ " và " +nghiem2.ToString());
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtA.Clear();
            this.txtB.Clear();
            this.txtC.Clear();
            this.txtNghiem.Clear();
            this.txtA.Focus();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
