using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhTienDien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            
            string chisocu = this.txtChiSokWhCu.Text;
            string chisomoi = this.txtChiSokWhMoi.Text;
            int n_chiso = System.Convert.ToInt32(chisomoi) - System.Convert.ToInt32(chisocu);
            this.txtTongkWhSuDung.Text = n_chiso.ToString();
            int dongiabac1=450, dongiabac2=700, dongiabac3=910, dongiabac4=1200;
            string tongtiensd;
            // hiển thị cac bậc
            if (n_chiso <= 50)
            {
                this.txtBac1.Text = 50 + "";
                this.txtSoTienBac1.Text = (dongiabac1 * 50).ToString();
                this.txtBac2.Text = "0";
                this.txtSoTienBac2.Text = "0";
                this.txtBac3.Text = "0";
                this.txtSoTienBac3.Text = "0";
                this.txtBac4.Text = "0";
                this.txtSoTienBac4.Text = "0";
                tongtiensd = (dongiabac1 * 50).ToString();
            }
            else
            {
                this.txtBac1.Text = "50";
                this.txtSoTienBac1.Text = (dongiabac1 * 50).ToString();
                int phanvuotdinhmuc = n_chiso - 50;
                if (phanvuotdinhmuc <= 50)
                {
                    this.txtBac2.Text = phanvuotdinhmuc + "";
                    this.txtSoTienBac2.Text = (phanvuotdinhmuc * dongiabac2).ToString();
                    this.txtBac3.Text = "0";
                    this.txtSoTienBac3.Text = "0";
                    this.txtBac4.Text = "0";
                    this.txtSoTienBac4.Text = "0";
                    tongtiensd = ((dongiabac1 * 50) + (phanvuotdinhmuc * dongiabac2)).ToString();
                }
                else if (phanvuotdinhmuc >= 50 && phanvuotdinhmuc <= 100)
                {
                    this.txtBac2.Text = "50";
                    this.txtSoTienBac2.Text = (50 * dongiabac2).ToString();
                    this.txtBac3.Text = (phanvuotdinhmuc-50)+"";
                    this.txtSoTienBac3.Text = ((phanvuotdinhmuc - 50) * dongiabac3).ToString();
                    this.txtBac4.Text = "0";
                    this.txtSoTienBac4.Text = "0";
                    tongtiensd = ((dongiabac1 * 50) + (50 * dongiabac2) + ((phanvuotdinhmuc - 50) * dongiabac3)).ToString();
                }
                else
                {
                    this.txtBac2.Text = "50";
                    this.txtSoTienBac2.Text = (50 * dongiabac2).ToString();
                    this.txtBac3.Text = "50";
                    this.txtSoTienBac3.Text = (50 * dongiabac3).ToString();
                    this.txtBac4.Text = (phanvuotdinhmuc - 100)+"";
                    this.txtSoTienBac4.Text = ((phanvuotdinhmuc - 100) * dongiabac4).ToString();
                    tongtiensd = ((dongiabac1 * 50) + (50 * dongiabac2) + (50 * dongiabac3) + ((phanvuotdinhmuc - 100) * dongiabac4)).ToString();
                }

            }
            this.txtTongTienSd.Text = tongtiensd.ToString()+" VNĐ";

            int tienvat = System.Convert.ToInt32(tongtiensd)/10;
            this.txtTongTienVAT.Text = tienvat + "" +" VNĐ";

            int tongtienphaitra = Convert.ToInt32(tongtiensd) + tienvat;
            this.txtTongTienPhaiTra.Text= tongtienphaitra.ToString() +" VNĐ";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtHoTenKH.Clear();
            this.txtChiSokWhCu.Clear();
            this.txtChiSokWhMoi.Clear();
            this.txtTongkWhSuDung.Clear();
            this.txtBac1.Clear();
            this.txtBac2.Clear();
            this.txtBac3.Clear();
            this.txtBac4.Clear();
            this.txtSoTienBac1.Clear();
            this.txtSoTienBac2.Clear();
            this.txtSoTienBac3.Clear();
            this.txtSoTienBac4.Clear();
            this.txtTongTienSd.Clear();
            this.txtTongTienPhaiTra.Clear();
            this.txtTongTienVAT.Clear();
            this.txtKQ.Clear();
            this.txtHoTenKH.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
           
            this.txtKQ.Text = "Khách hàng: " + this.txtHoTenKH.Text + "\r\n"
             + "Tổng kWh sử dụng: " + this.txtTongkWhSuDung.Text + "\r\n"
             + "Tổng tiền phải trả: " + this.txtTongTienPhaiTra.Text; 
        }
    }
}
