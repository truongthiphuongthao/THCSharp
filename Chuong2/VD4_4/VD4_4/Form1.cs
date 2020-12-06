using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD4_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 10;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBD_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblDongHo.Text = i.ToString();
            i--;
            if (i < 0)
            {
                this.timer1.Enabled = false;
                this.lblDongHo.Text = "Hết giờ!";
            }
        }
    }
}
