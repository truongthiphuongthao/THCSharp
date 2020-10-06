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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a, b;
            a = this.txtA.Text;
            b = this.txtB.Text;
            double ketqua;
            if(a == "0")
            {
                if(b == "0")
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
                ketqua = -(Convert.ToDouble(b) / Convert.ToDouble(a));
                double ketqualamtron = Math.Round(ketqua, 2);
                txtNghiem.AppendText(ketqualamtron.ToString());
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtA.Clear();
            this.txtB.Clear();
            this.txtNghiem.Clear();
            this.txtA.Focus();
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
