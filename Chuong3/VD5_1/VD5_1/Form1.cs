using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD5_1
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

        private void btnIn_Click(object sender, EventArgs e)
        {
            int[] array = { 2, 4, 5, 6, 8 };
            txbKQ.Text = "Các phần tử trong mảng là\n\r";

            for(int i=0;i<array.Length; i++)
            {
                txbKQ.Text += array[i] + " ";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txbKQ.Clear();
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
