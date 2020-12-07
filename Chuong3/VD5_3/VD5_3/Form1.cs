using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD5_3
{
    public partial class Form1 : Form
    {
        // khai báo số dòng, số cột
        const int sodong = 2;
        const int socot = 3;
        // khai báo mảng 2 chiều có 2 dòng 3 cột
        int[ , ] array2 = new int [sodong, socot];
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            // nhập mảng
            for(int i=0; i<sodong; i++)
            {
                for(int j =0; j<socot; j++)
                {
                    array2[i, j] = i - j;
                }
            }
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            // Sap xep mang
            int[] t = new int[sodong * socot];
            for (int i = 0; i < sodong; i++)
            {
                for (int j = 0; j < socot; j++)
                    t[j] = array2[i, j];
                    Array.Sort(t, 0, socot);
                    for (int j = 0; j < socot; j++)
                        array2[i, j] = t[j];
                
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            this.txtKQ.Text = " Các phần tử trong mảng \n\r";
            for(int i=0; i< sodong; i++)
            {
                for(int j=0; j<socot; j++)
                {
                    this.txtKQ.Text += array2[i, j]+ " ";
                }
                this.txtKQ.Text += "\n\r";

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtKQ.Clear();
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
