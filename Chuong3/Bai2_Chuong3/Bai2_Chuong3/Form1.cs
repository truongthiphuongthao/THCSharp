using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2_Chuong3
{
    public partial class Form1 : Form
    {
        // 4 dòng 5 cột
        const int sodong = 4;
        const int socot = 5;
        // khai bao mảng có 4 dòng 5 cột
        int[,] array = new int[4, 5];
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            int i, j;
            for(i=0;i<sodong; i++)
            {
                for(j=0; j<socot; j++)
                {
                    array[i, j] = i + j;
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            int i, j;
            for (i = 0; i < sodong; i++)
            {
                for(j=0; j<socot; j++)
                {
                    this.txbKQ.Text += array[i,j] + " ";
                }
                this.txbKQ.Text += "\n\r";
            }
            // hien thi phan tu nho nhat
            int ptnhonhat = PhanTuNhoNhat();
            // hien thi phan tu lon nhat
            int ptlonnhat = PhanTuLonNhat();
            // hien thị tong cac gia tri
            int tongcacgiatri = TongCacGiaTri();
            // trung binh cac phan tu
            double trungbinhcacphantu = TinhTrungBinhCong();
            this.txbKQ.AppendText("\nIn giá trị nhỏ nhất: " + ptnhonhat + "\n\r"+ 
                                    "In giá trị lớn nhất: "+ptlonnhat+ "\n\r"+
                                    "Tổng các giá trị: "+tongcacgiatri + "\n\r"+
                                    "Trung bình các giá trị: "+String.Format("{0:0.00}",trungbinhcacphantu));
        }

        // in phần tử nhỏ nhất trong mảng

        public int PhanTuNhoNhat()
        {
            int i, j;
            int ptnhonhat = Convert.ToInt32(array[0,0]);
            for(i=0; i<sodong; i++)
            {
                for(j=0; j<socot; j++)
                {
                    if (ptnhonhat >= array[i, j])
                    {
                        ptnhonhat = array[i, j];
                    }
                }
            }
            return ptnhonhat;
        }

        // in phan tu lon nhat
        public int PhanTuLonNhat()
        {
            int i, j;
            int ptlonnhat = Convert.ToInt32(array[0,0]);
            for(i=0; i<sodong; i++)
            {
                for(j=0; j < socot; j++)
                {
                    if(ptlonnhat <= array[i, j])
                    {
                        ptlonnhat = array[i, j];
                    }
                }
            }
            return ptlonnhat;
        }

        // tổng số các giá trị
        public int TongCacGiaTri()
        {
            int i, j;
            int tong = 0;
            for(i=0; i<sodong; i++)
            {
                for(j=0; j<socot; j++)
                {
                    tong += array[i, j];
                }
            }

            return tong;
        }

        // tinh trung binh cong
        public double TinhTrungBinhCong()
        {
            int tong = TongCacGiaTri();
            int cacptu = sodong * socot;
            double tb = tong / (cacptu * 1.0);
            return tb;
        }

    }
}
