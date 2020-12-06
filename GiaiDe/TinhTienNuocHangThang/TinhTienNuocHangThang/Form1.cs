using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhTienNuocHangThang
{
    public partial class Form1 : Form
    {
        bool tinh = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int chisomoi = Convert.ToInt32(this.txtChiSoMoi.Text);
            int chisocu = Convert.ToInt32(this.txtChiSoCu.Text);
            // tinh so met khoi su dung
            int tongmetkhoisd = Convert.ToInt32(chisomoi) - Convert.ToInt32(chisocu);
            this.txtTongMetKhoiSD.Text = tongmetkhoisd.ToString();
            // tinh dinh muc
            int sonhankhau = Convert.ToInt32(this.txtSoNhanKhau.Text);
            int dinhmuc, trongdinhmuc, vuotdinhmuc;
            dinhmuc = TinhSoNhanKhau(sonhankhau);
            // tinh so met khoi trong dinh muc va so met khoi vuot dinh muc
            if (tongmetkhoisd <= dinhmuc)
            {
                trongdinhmuc = tongmetkhoisd;
                vuotdinhmuc = 0;
            }
            else
            {
                trongdinhmuc = dinhmuc;
                vuotdinhmuc = tongmetkhoisd - dinhmuc;
            }
            this.txtTrongDinhMuc.Text = trongdinhmuc.ToString();
            this.txtVuotDinhMuc.Text = vuotdinhmuc.ToString();
            // tinh tong tien su dung
            int tongtiensd = trongdinhmuc * 4000 + vuotdinhmuc * 8000;
            this.txtTongTienSD.Text = tongtiensd.ToString() + " VND";
            // tinh tong tien vat
            int tongtienvat = tongtiensd / 10;
            this.txtTongTienVAT.Text = tongtienvat.ToString() + " VND";
            // tong tien phai tra
            int tongtienphaitra = tongtiensd + tongtienvat;
            this.txtTongTienPT.Text = tongtienphaitra.ToString() + " VND";
            tinh = true;
            btnIn.Enabled = tinh;
        }
        // tinh so nhan khau
        private int TinhSoNhanKhau(int sonhankhau)
        {
            int dinhmuc;
            if(sonhankhau < 4)
            {
                dinhmuc = 12;
                return dinhmuc;
            }
            else
            {
                dinhmuc = sonhankhau * 4;
                return dinhmuc;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtHoTenKH.Clear();
            this.txtSoNhanKhau.Clear();
            this.txtChiSoCu.Clear();
            this.txtChiSoMoi.Clear();
            this.txtTongMetKhoiSD.Clear();
            this.txtTrongDinhMuc.Clear();
            this.txtVuotDinhMuc.Clear();
            this.txtTongTienSD.Clear();
            this.txtTongTienVAT.Clear();
            this.txtTongTienPT.Clear();
            this.txtKQ.Clear();
            this.txtHoTenKH.Focus();
            btnIn.Enabled = tinh;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            this.txtKQ.Text = "Khách hàng: " + this.txtHoTenKH.Text + "\r\n" +
                              "Số nhân khẩu: " + this.txtSoNhanKhau.Text + "\r\n" +
                              "Tổng số mét khối sử dụng: " + this.txtTongMetKhoiSD.Text + "\r\n" +
                              "Trong định mức: " + this.txtTrongDinhMuc.Text + "\r\n" +
                              "Vượt định mức: " + this.txtVuotDinhMuc.Text + "\r\n" +
                              "Tổng tiền phải trả: " + this.txtTongTienPT.Text + "\r\n";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnXoa_Click(null, null);
        }
    }
}
