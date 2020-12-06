using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhTienDien1
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
            int cs;
            cs = Convert.ToInt32(this.txbChiSoDienKeMoi.Text) - Convert.ToInt32(this.txbChiSoDienKeCu.Text);
            this.txbTongSokWDaSuDung.Text = cs.ToString();
            int dongia1 = 450, dongia2 = 700, dongia3 = 910, dongia4 = 1200;
            int sokwdm = Convert.ToInt32(this.txbSokWhDinhMuc.Text);
            int sotienmuc1, sotienmuc2, sotienmuc3, sotienmuc4, phanvuotdinhmuc, tongtiensudung;
            if (cs <= sokwdm)
            {
                this.txbSokWMuc1.Text = cs.ToString();
                sotienmuc1 = cs * 450;
                this.txbSoTienPhaiTraMuc1.Text = sotienmuc1.ToString();
                this.txbSokWMuc2.Text = "0";
                this.txbSoTienPhaiTraMuc2.Text = "0";
                this.txbSokWMuc3.Text = "0";
                this.txbSoTienPhaiTraMuc3.Text = "0";
                this.txbSokWMuc4.Text = "0";
                this.txbSoTienPhaiTraMuc4.Text = "0";
                tongtiensudung = sotienmuc1;
            }
            else
            {
                phanvuotdinhmuc = cs - sokwdm;
                if (phanvuotdinhmuc <= 50)
                {
                    this.txbSokWMuc1.Text = this.txbSokWhDinhMuc.Text;
                    sotienmuc1 = sokwdm * 450;
                    this.txbSoTienPhaiTraMuc1.Text = sotienmuc1.ToString() + " VNĐ";
                    this.txbSokWMuc2.Text = phanvuotdinhmuc.ToString();
                    sotienmuc2 = phanvuotdinhmuc * 700;
                    this.txbSoTienPhaiTraMuc2.Text = sotienmuc2.ToString() + " VNĐ";
                    this.txbSokWMuc3.Text = "0";
                    this.txbSokWMuc4.Text = "0";
                    this.txbSoTienPhaiTraMuc3.Text = "0";
                    this.txbSoTienPhaiTraMuc4.Text = "0";
                    tongtiensudung = sotienmuc1 + sotienmuc2;

                }
                else if (phanvuotdinhmuc >=50  && phanvuotdinhmuc <=100)
                {
                    this.txbSokWMuc1.Text = this.txbSokWhDinhMuc.Text;
                    sotienmuc1 = sokwdm * 450;
                    this.txbSoTienPhaiTraMuc1.Text = sotienmuc1.ToString() + " VNĐ";
                    this.txbSokWMuc2.Text = "50";
                    sotienmuc2 = 50 * 700;
                    this.txbSoTienPhaiTraMuc2.Text = sotienmuc2.ToString() + " VNĐ";
                    this.txbSokWMuc3.Text = (phanvuotdinhmuc - 50).ToString();
                    sotienmuc3 = (phanvuotdinhmuc - 50) * 910;
                    this.txbSoTienPhaiTraMuc3.Text = sotienmuc3.ToString() + " VNĐ";
                    tongtiensudung = sotienmuc1 + sotienmuc2 + sotienmuc3;
                }
                else
                {
                    this.txbSokWMuc1.Text = this.txbSokWhDinhMuc.Text;
                    sotienmuc1 = sokwdm * 450;
                    this.txbSoTienPhaiTraMuc1.Text = sotienmuc1.ToString() + " VNĐ";
                    this.txbSokWMuc2.Text = "50";
                    sotienmuc2 = 50 * 700;
                    this.txbSoTienPhaiTraMuc2.Text = sotienmuc2.ToString() + " VNĐ";
                    this.txbSokWMuc3.Text = "50";
                    sotienmuc3 = 50 * 910;
                    this.txbSoTienPhaiTraMuc3.Text = sotienmuc3.ToString() + " VNĐ";
                    this.txbSokWMuc4.Text = (phanvuotdinhmuc - 100).ToString();
                    sotienmuc4 = (phanvuotdinhmuc - 100) * 1200;
                    this.txbSoTienPhaiTraMuc4.Text = sotienmuc4.ToString() + " VNĐ";
                    tongtiensudung = sotienmuc1 + sotienmuc2 + sotienmuc3 +sotienmuc4;
                }
            }
            // in tong tien phai tra
            int tienthuedienke = Convert.ToInt32(this.txbTienThueDienKe.Text);
            int tongtienphaitra = tongtiensudung + tienthuedienke;
            this.txbTongSoTienPhaiTra.Text = tongtienphaitra.ToString()+" VNĐ";

            tinh = true;
            btnIn.Enabled = tinh;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txbHoTen.Clear();
            this.txbChiSoDienKeCu.Clear();
            this.txbChiSoDienKeMoi.Clear();
            this.txbSokWMuc1.Clear();
            this.txbSokWMuc2.Clear();
            this.txbSokWMuc3.Clear();
            this.txbSokWMuc4.Clear();
            this.txbSoTienPhaiTraMuc1.Clear();
            this.txbSoTienPhaiTraMuc2.Clear();
            this.txbSoTienPhaiTraMuc3.Clear();
            this.txbSoTienPhaiTraMuc4.Clear();
            this.txbTongSokWDaSuDung.Clear();
            this.txbTongSoTienPhaiTra.Clear();
            this.txbKQ.Clear();
            this.txbSokWhDinhMuc.Clear();
            btnIn.Enabled = tinh;
        }

        private void txbChiSoDienKeCu_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            this.txbKQ.Text = "Khách hàng: " + this.txbHoTen.Text + Environment.NewLine + 
                               "Tổng số Kw sử dụng: "+this.txbTongSokWDaSuDung.Text + Environment.NewLine 
                               + "Tổng tiền phải trả: "+ this.txbTongSoTienPhaiTra.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnXoa_Click(null, null);
        }
    }
}
    
