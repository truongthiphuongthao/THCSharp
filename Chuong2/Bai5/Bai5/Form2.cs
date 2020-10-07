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

        private void btnGiai_Click(object sender, EventArgs e)
        {
            string b, c;
            b = this.txtB.Text;
            c = this.txtC.Text;
            double n_b, n_c, nghiem;
            n_b = Convert.ToDouble(b);
            n_c = Convert.ToDouble(c);
            if(n_b == 0)
            {
                if (n_c == 0)
                {
                    txtNghiem.AppendText("Vô Số Nghiệm");
                }
                else
                {
                    txtNghiem.AppendText("Vô Nghiệm");
                }
            }
            else
            {
                nghiem = Math.Round(-(n_c) / (n_b), 2);
                txtNghiem.AppendText(nghiem.ToString());
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtB.Clear();
            this.txtC.Clear();
            this.txtNghiem.Clear();
            this.txtB.Focus();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
            Form form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
