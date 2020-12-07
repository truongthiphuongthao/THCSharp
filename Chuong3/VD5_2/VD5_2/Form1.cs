using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD5_2
{
    public partial class Form1 : Form
    {
        int[] array = new int[5];
        int index = 0;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void btnNhapMang_Click(object sender, EventArgs e)
        {
            // Nhập 1 phần tử trong mảng vào mảng 
            if(index == 5)
            {
                MessageBox.Show("Mảng đã đầy");
            }
            else
            {
                array[index] = Convert.ToInt32(this.txtnhap.Text);
                index++;
                this.txtnhap.ResetText();
                this.txtnhap.Focus();
                
                
            }
        }

        private void btnSapTang_Click(object sender, EventArgs e)
        {
            // Mảng rỗng
            if(index == 0)
            {
                this.txbKQ.Text = "Mảng rỗng !";
            }
            else
            {
                Array.Sort(array, 0, index);
                this.txbKQ.Text = "Đã sắp xếp mảng tăng dần: ";
            }
        }

        private void btnSapGiam_Click(object sender, EventArgs e)
        {
            if(index == 0)
            {
                this.txbKQ.Text = "Mảng rỗng !";
            }
            else
            {
                Array.Reverse(array, 0, index);
                this.txbKQ.Text = "Đã sắp xếp mảng giảm dần: ";
            }
        }

        private void btnInMang_Click(object sender, EventArgs e)
        {
            // in mảng ra man hinh
            if(index == 0)
            {
                this.txbKQ.Text = "Mảng rỗng!";
            }
            else
            {
                for(int i=0;i<index; i++)
                {
                    this.txbKQ.Text += array[i] + " ";
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtnhap.Clear();
            this.txbKQ.Clear();
            this.txtnhap.Focus();
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
