using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaiPTBac2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            string a, b, c;
            a = this.txtA.Text;
            b = this.txtB.Text;
            c = this.txtC.Text;
            double nghiem, candenta, nghiem1, nghiem2;
            double denta = Convert.ToDouble(b) * Convert.ToDouble(b) - 4 * Convert.ToDouble(a) * Convert.ToDouble(c);
            candenta = denta / 2;
            if( denta < 0 )
            {
                txtNghiem.AppendText("Vô Nghiệm");
            }
            else if ( denta == 0)
            {
                nghiem = Math.Round(-(Convert.ToDouble(b)) / (2 * Convert.ToDouble(a)), 2);
                txtNghiem.AppendText(nghiem.ToString());
            }
            else
            {
                nghiem1 = Math.Round(-(Convert.ToDouble(b) + candenta) / (2 * Convert.ToDouble(a)), 2);
                nghiem2 = Math.Round(-(Convert.ToDouble(b) - candenta) / (2 * Convert.ToDouble(a)), 2);
                txtNghiem.AppendText(nghiem1.ToString() + Environment.NewLine) ;
                txtNghiem.AppendText(" và "+  nghiem2.ToString());

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

        private void btnDung_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không? ", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }
    }
}
