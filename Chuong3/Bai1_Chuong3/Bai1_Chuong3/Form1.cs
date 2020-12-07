using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_Chuong3
{
    public partial class Form1 : Form
    {
        // khai báo mảng có tối đa 10 phần tử
        int[] array = new int[10];
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if(index == 10)
            {
                MessageBox.Show("Mảng đã đầy!");
            }
            else
            {
                array[index] = Convert.ToInt32(this.txbNhap.Text);
                index++;
                this.txbNhap.ResetText();
                this.txbNhap.Focus();
            }
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
           // in mảng rỗng
           if(index == 0)
            {
                this.txbKQ.Text = "Mảng rỗng !";
            }
            // có phần tử
            else
            {
                int i;
                string s = "";
                for(i=0; i < index; i++)
                {
                    s += array[i] + " ";
                }
               
                int max_screen = TinhGiaTriLonNhat();
                int min_screen = TinhGiaTriNhoNhat();
                int sum_screen = TongCacGiaTri();
                double average_screen = TinhTrungBinhCong(); 
                // hiển thị ra text
                this.txbKQ.Text = " In giá trị của các phần tử trong mảng" + Environment.NewLine + s + 
                                  "\n In giá trị lớn nhất trong mảng" +Environment.NewLine + max_screen +
                                  "\n In giá trị nhỏ nhất trong mảng" +Environment.NewLine +min_screen +
                                  "\n Tổng các giá trị trong mảng" +Environment.NewLine +sum_screen +
                                  "\n Trung bình cộng của mảng: " + Environment.NewLine + String.Format("{0:0.00}", average_screen);
                

            }
        }

       // in gia tri lon nhat trong mang
       private int TinhGiaTriLonNhat()
       {
             int max = array[0];
             for(int i = 0; i < index; i++)
             {
                    if(max <= array[i])
                    {
                        max = array[i];
                    }
             }
         
            return max;
        }

        // in gia tri nho nhat trong mang

        private int TinhGiaTriNhoNhat()
        {
            int min = array[0];
            for(int i=0; i<index; i++)
            {
                if(min >= array[i])
                {
                    min = array[i];
                }
            }
            return min;
        }

        // in tổng các giá trị trong mảng
        private int TongCacGiaTri()
        {
           int sum = 0;
           for(int i = 0; i < index; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        // tinh trung binh cong cac phan tu trong mang

        private double TinhTrungBinhCong()
        {
            int sum = TongCacGiaTri();
            double sum_res = sum / (1.0*index);

            return sum_res; // String.Format()//ath.Round(sum_res,2);
        }
        
    }
}
