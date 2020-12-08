using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaiPTBac1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {

            try
            {
                double n_b = double.Parse(this.txbB.Text);
                double n_c = double.Parse(this.txbC.Text);
                if (n_b == 0)
                {
                    if(n_c == 0)
                    {
                        this.txbKQ.Text += "Phương trình vô số nghiệm";
                    }
                    else
                    {
                        this.txbKQ.Text += "Phương trình vô nghiệm";
                    }
                }
                else
                {
                    double x = -n_c / n_b;
                    this.txbKQ.Text += String.Format("{0:0.00}", x);
                }
            }catch(Exception ex)
            {
                this.txbKQ.Text += "Lỗi r";
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txbB.Clear();
            this.txbC.Clear();
            this.txbB.Focus();
        }
    }
}
