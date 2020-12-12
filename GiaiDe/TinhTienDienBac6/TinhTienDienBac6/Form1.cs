using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhTienDienBac6
{
    public partial class Form1 : Form
    {
        int dgbac1 = 500, dgbac2 = 700, dgbac3 = 900, dgbac4 = 1100, dgbac5 = 1300, dgbac6 = 1500;

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Chắc không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(traloi == DialogResult.OK)
            {
                Application.Exit();
            }

        }

        private void btnIn_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtHoTenKH.Clear();
            this.txtChiSokWhCu.Clear();
            this.txtChiSokWhMoi.Clear();
            this.txtSoKwhTThuBac1.Clear();
            this.txtSoKwhTThuBac2.Clear();
            this.txtSoKwhTThuBac3.Clear();
            this.txtSoKwhTThuBac4.Clear();
            this.txtSoKwhTThuBac5.Clear();
            this.txtSoKwhTThuBac6.Clear();
            this.txtSoTienBac1.Clear();
            this.txtSoTienBac2.Clear();
            this.txtSoTienBac3.Clear();
            this.txtSoTienBac4.Clear();
            this.txtSoTienBac5.Clear();
            this.txtSoTienBac6.Clear();
            this.txtTongkWhSuDung.Clear();
            this.txtTongTienPT.Clear();
            this.txtTongTienSD.Clear();
            this.txtTongTienVAT.Clear();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void txtTongkWhSuDung_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int cscu, csmoi, tongsd;
            cscu = Convert.ToInt32(this.txtChiSokWhCu.Text);
            csmoi = Convert.ToInt32(this.txtChiSokWhMoi.Text);
            tongsd = csmoi - cscu;
            this.txtTongkWhSuDung.Text += tongsd.ToString();
            if(tongsd > 400)
            {
                this.txtSoKwhTThuBac1.Text += "50";
                this.txtSoKwhTThuBac2.Text += "50";
                this.txtSoKwhTThuBac3.Text += "100";
                this.txtSoKwhTThuBac4.Text += "100";
                this.txtSoKwhTThuBac5.Text += "100";
                this.txtSoKwhTThuBac6.Text += (tongsd - 400).ToString();
                // tính tiền
                this.txtSoTienBac1.Text += (dgbac1 * 50).ToString();
                this.txtSoTienBac2.Text += (dgbac2 * 50).ToString();
                this.txtSoTienBac3.Text += (dgbac3 * 100).ToString();
                this.txtSoTienBac4.Text += (dgbac4 * 100).ToString();
                this.txtSoTienBac5.Text += (dgbac5 * 100).ToString();
                this.txtSoTienBac6.Text += (dgbac6 * (tongsd - 400)).ToString();
                // tính tổng tiền sử dụng
                this.txtTongTienSD.Text += ((dgbac1 * 50) + (dgbac2 * 50) + (dgbac3 * 100) + (dgbac4 * 100) + (dgbac5 * 100) + (dgbac6 * (tongsd - 400))).ToString()+" VND";
                // tính vat
                this.txtTongTienVAT.Text += (((dgbac1 * 50) + (dgbac2 * 50) + (dgbac3 * 100) + (dgbac4 * 100) + (dgbac5 * 100) + (dgbac6 * (tongsd - 400))) / 10).ToString() + " VND";
                // tính tổng tiền phải trả
                this.txtTongTienPT.Text += (((dgbac1 * 50) + (dgbac2 * 50) + (dgbac3 * 100) + (dgbac4 * 100) + (dgbac5 * 100) + (dgbac6 * (tongsd - 400))) + (((dgbac1 * 50) + (dgbac2 * 50) + (dgbac3 * 100) + (dgbac4 * 100) + (dgbac5 * 100) + (dgbac6 * (tongsd - 400))) / 10)).ToString() + " VND";
                // in
                
            }
            else if(tongsd>300 && tongsd <= 400)
            {
                this.txtSoKwhTThuBac1.Text += "50";
                this.txtSoKwhTThuBac2.Text += "50";
                this.txtSoKwhTThuBac3.Text += "100";
                this.txtSoKwhTThuBac4.Text += "100";
                this.txtSoKwhTThuBac5.Text += (tongsd - 300).ToString();
                this.txtSoKwhTThuBac6.Text += "0";
                // tính tiền
                this.txtSoTienBac1.Text += (dgbac1 * 50).ToString();
                this.txtSoTienBac2.Text += (dgbac2 * 50).ToString();
                this.txtSoTienBac3.Text += (dgbac3 * 100).ToString();
                this.txtSoTienBac4.Text += (dgbac4 * 100).ToString();
                this.txtSoTienBac5.Text += (dgbac5 * (tongsd - 300)).ToString();
                this.txtSoTienBac6.Text += (dgbac6 * 0).ToString();
                // tính tổng tiền sử dụng
                this.txtTongTienSD.Text += ((dgbac1 * 50)+ (dgbac2 * 50)+ (dgbac3 * 100)+ (dgbac4 * 100) + (dgbac5 * (tongsd - 300))).ToString() + " VND";
                // tính vat
                this.txtTongTienVAT.Text += (((dgbac1 * 50) + (dgbac2 * 50) + (dgbac3 * 100) + (dgbac4 * 100) + (dgbac5 * (tongsd - 300))) / 10).ToString() + " VND";
                // tính tổng tiển phải trả
                this.txtTongTienPT.Text += (((dgbac1 * 50) + (dgbac2 * 50) + (dgbac3 * 100) + (dgbac4 * 100) + (dgbac5 * (tongsd - 300))) + (((dgbac1 * 50) + (dgbac2 * 50) + (dgbac3 * 100) + (dgbac4 * 100) + (dgbac5 * (tongsd - 300))) / 10)).ToString() + " VND";
            }
            else if(tongsd>200 && tongsd <= 300)
            {
                this.txtSoKwhTThuBac1.Text += "50";
                this.txtSoKwhTThuBac2.Text += "50";
                this.txtSoKwhTThuBac3.Text += "100";
                this.txtSoKwhTThuBac4.Text += (tongsd - 200).ToString();
                this.txtSoKwhTThuBac5.Text += "0";
                this.txtSoKwhTThuBac6.Text += "0";
                // tính tiền
                this.txtSoTienBac1.Text += (dgbac1 * 50).ToString();
                this.txtSoTienBac2.Text += (dgbac2 * 50).ToString();
                this.txtSoTienBac3.Text += (dgbac3 * 100).ToString();
                this.txtSoTienBac4.Text += (dgbac4 * (tongsd - 200)).ToString();
                this.txtSoTienBac5.Text += (dgbac5 * 0).ToString();
                this.txtSoTienBac6.Text += (dgbac6 * 0).ToString();
                // tính tổng tiền sd
                this.txtTongTienSD.Text += ((dgbac1 * 50) + (dgbac2 * 50) + (dgbac3 * 100) + (dgbac4 * (tongsd - 200))).ToString() + " VND";
                // tính vat
                this.txtTongTienVAT.Text += (((dgbac1 * 50) + (dgbac2 * 50) + (dgbac3 * 100) + (dgbac4 * (tongsd - 200))) / 10).ToString() + " VND";
                // tinh tong tien phai tra
                this.txtTongTienPT.Text += (((dgbac1 * 50) + (dgbac2 * 50) + (dgbac3 * 100) + (dgbac4 * (tongsd - 200))) + (((dgbac1 * 50) + (dgbac2 * 50) + (dgbac3 * 100) + (dgbac4 * (tongsd - 200))) / 10)).ToString() + " VND";

            }
            else if(tongsd>100 && tongsd <= 200)
            {
                this.txtSoKwhTThuBac1.Text += "50";
                this.txtSoKwhTThuBac2.Text += "50";
                this.txtSoKwhTThuBac3.Text += (tongsd - 100).ToString();
                this.txtSoKwhTThuBac4.Text += "0";
                this.txtSoKwhTThuBac5.Text += "0";
                this.txtSoKwhTThuBac6.Text += "0";
                // tính tiền
                this.txtSoTienBac1.Text += (dgbac1 * 50).ToString();
                this.txtSoTienBac2.Text += (dgbac2 * 50).ToString();
                this.txtSoTienBac3.Text += (dgbac3 * (tongsd - 100)).ToString();
                this.txtSoTienBac4.Text += (dgbac4 * 0).ToString();
                this.txtSoTienBac5.Text += (dgbac5 * 0).ToString();
                this.txtSoTienBac6.Text += (dgbac6 * 0).ToString();
                // tính tổng tiền sử dụng
                this.txtTongTienSD.Text += ((dgbac1 * 50) + (dgbac2 * 50) + (dgbac3 * (tongsd - 100))).ToString() + " VND";
                // tính vat
                this.txtTongTienVAT.Text += (((dgbac1 * 50) + (dgbac2 * 50) + (dgbac3 * (tongsd - 100))) / 10).ToString() + " VND";
                // tính tong tien phai tra
                this.txtTongTienPT.Text += (((dgbac1 * 50) + (dgbac2 * 50) + (dgbac3 * (tongsd - 100))) + (((dgbac1 * 50) + (dgbac2 * 50) + (dgbac3 * (tongsd - 100))) / 10)).ToString() + " VND";
            }
            else if(tongsd>50 && tongsd <= 100)
            {
                this.txtSoKwhTThuBac1.Text += "50";
                this.txtSoKwhTThuBac2.Text += (tongsd - 50).ToString();
                this.txtSoKwhTThuBac3.Text += "0";
                this.txtSoKwhTThuBac4.Text += "0";
                this.txtSoKwhTThuBac5.Text += "0";
                this.txtSoKwhTThuBac6.Text += "0";
                // tính tiền
                this.txtSoTienBac1.Text += (dgbac1 * 50).ToString();
                this.txtSoTienBac2.Text += (dgbac2 * (tongsd - 50)).ToString();
                this.txtSoTienBac3.Text += (dgbac3 * 0).ToString();
                this.txtSoTienBac4.Text += (dgbac4 * 0).ToString();
                this.txtSoTienBac5.Text += (dgbac5 * 0).ToString();
                this.txtSoTienBac6.Text += (dgbac6 * 0).ToString();
                // tính tổng tiền sử dụng
                this.txtTongTienSD.Text += ((dgbac1 * 50) + (dgbac2 * (tongsd - 50))).ToString() + " VND";
                // tính vat
                this.txtTongTienVAT.Text += (((dgbac1 * 50) + (dgbac2 * (tongsd - 50))) / 10).ToString() + " VND";
                // tính tổng tiền phải trả
                this.txtTongTienPT.Text += (((dgbac1 * 50) + (dgbac2 * (tongsd - 50))) + (((dgbac1 * 50) + (dgbac2 * (tongsd - 50))) / 10)).ToString() + " VND";
            }
            else
            {
                this.txtSoKwhTThuBac1.Text += tongsd.ToString();
                this.txtSoKwhTThuBac2.Text += "0";
                this.txtSoKwhTThuBac3.Text += "0";
                this.txtSoKwhTThuBac4.Text += "0";
                this.txtSoKwhTThuBac5.Text += "0";
                this.txtSoKwhTThuBac6.Text += "0";
                // tính tiền
                this.txtSoTienBac1.Text += (dgbac1 * tongsd).ToString();
                this.txtSoTienBac2.Text += (dgbac2 * 0).ToString();
                this.txtSoTienBac3.Text += (dgbac3 * 0).ToString();
                this.txtSoTienBac4.Text += (dgbac4 * 0).ToString();
                this.txtSoTienBac5.Text += (dgbac5 * 0).ToString();
                this.txtSoTienBac6.Text += (dgbac6 * 0).ToString();
                // tính tổng tiền sử dụng
                this.txtTongTienSD.Text += (dgbac1 * tongsd).ToString()+" VND";
                // tính vat
                this.txtTongTienVAT.Text += ((dgbac1 * tongsd) / 10).ToString() + " VND";
                // tính tổng tiền phải trả
                this.txtTongTienPT.Text += ((dgbac1 * tongsd) + ((dgbac1 * tongsd) / 10)).ToString() + " VND";
            }
            this.txtKQ.Text += "Khách hàng: " + this.txtHoTenKH.Text + "\r\n" +
                                "Tổng kWh sử dụng: " + this.txtTongkWhSuDung.Text + "\r\n" +
                                "Tổng tiền phải trả: " + this.txtTongTienPT.Text;
        }
    }
}
