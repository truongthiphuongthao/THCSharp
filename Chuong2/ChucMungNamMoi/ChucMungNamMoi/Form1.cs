using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChucMungNamMoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        string str1 = "", str2 = "";
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnChay_Click(object sender, EventArgs e)
        {
            if(btnChay.Text == "Chạy")
            {
                this.timer1.Enabled = true;
                this.btnChay.Text = "Dừng";
            }
            else
            {
                this.timer1.Enabled = false;
                this.btnChay.Text = "Chạy";
            }
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            string str = "CHÚC MỪNG NĂM MỚI - HAPPY NEW YEAR";
            lblKQ.Text = str.Remove(i);
            i++;
            if (i >= str.Length)
            {
                lblKQ.ForeColor = Color.Red;
                lblKQ.Text = str;
                i = 0;
            }
        }
    }
}
