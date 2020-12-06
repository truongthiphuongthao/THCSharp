namespace TinhTienNuocHangThang
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.RichTextBox();
            this.txtHoTenKH = new System.Windows.Forms.TextBox();
            this.txtSoNhanKhau = new System.Windows.Forms.TextBox();
            this.txtChiSoCu = new System.Windows.Forms.TextBox();
            this.txtChiSoMoi = new System.Windows.Forms.TextBox();
            this.txtTongMetKhoiSD = new System.Windows.Forms.TextBox();
            this.txtTrongDinhMuc = new System.Windows.Forms.TextBox();
            this.txtVuotDinhMuc = new System.Windows.Forms.TextBox();
            this.txtTongTienSD = new System.Windows.Forms.TextBox();
            this.txtTongTienVAT = new System.Windows.Forms.TextBox();
            this.txtTongTienPT = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÍNH TIỀN NƯỚC HÀNG THÁNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số nhân khẩu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chỉ số mới";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tổng số mét khối sử dụng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Chỉ số cũ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số mét khối trong định mức:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(85, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Số mét khối vượt định mức:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(85, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tổng tiền sử dụng:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(85, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "VAT 10%:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(85, 357);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Tổng tiền phải trả:";
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(189, 405);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTinh.TabIndex = 11;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(288, 405);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.TabIndex = 12;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(380, 405);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(474, 405);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(489, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(173, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Trong định mức: 4000đ/1 mét khối";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(489, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(167, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Vượt định mức: 8000đ/1 mét khối";
            // 
            // txtKQ
            // 
            this.txtKQ.Enabled = false;
            this.txtKQ.Location = new System.Drawing.Point(508, 236);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(211, 134);
            this.txtKQ.TabIndex = 17;
            this.txtKQ.Text = "";
            // 
            // txtHoTenKH
            // 
            this.txtHoTenKH.Location = new System.Drawing.Point(164, 53);
            this.txtHoTenKH.Name = "txtHoTenKH";
            this.txtHoTenKH.Size = new System.Drawing.Size(100, 20);
            this.txtHoTenKH.TabIndex = 18;
            // 
            // txtSoNhanKhau
            // 
            this.txtSoNhanKhau.Location = new System.Drawing.Point(164, 84);
            this.txtSoNhanKhau.Name = "txtSoNhanKhau";
            this.txtSoNhanKhau.Size = new System.Drawing.Size(100, 20);
            this.txtSoNhanKhau.TabIndex = 19;
            // 
            // txtChiSoCu
            // 
            this.txtChiSoCu.Location = new System.Drawing.Point(164, 117);
            this.txtChiSoCu.Name = "txtChiSoCu";
            this.txtChiSoCu.Size = new System.Drawing.Size(100, 20);
            this.txtChiSoCu.TabIndex = 20;
            // 
            // txtChiSoMoi
            // 
            this.txtChiSoMoi.Location = new System.Drawing.Point(355, 121);
            this.txtChiSoMoi.Name = "txtChiSoMoi";
            this.txtChiSoMoi.Size = new System.Drawing.Size(100, 20);
            this.txtChiSoMoi.TabIndex = 21;
            // 
            // txtTongMetKhoiSD
            // 
            this.txtTongMetKhoiSD.Location = new System.Drawing.Point(223, 166);
            this.txtTongMetKhoiSD.Name = "txtTongMetKhoiSD";
            this.txtTongMetKhoiSD.ReadOnly = true;
            this.txtTongMetKhoiSD.Size = new System.Drawing.Size(100, 20);
            this.txtTongMetKhoiSD.TabIndex = 22;
            // 
            // txtTrongDinhMuc
            // 
            this.txtTrongDinhMuc.Location = new System.Drawing.Point(223, 196);
            this.txtTrongDinhMuc.Name = "txtTrongDinhMuc";
            this.txtTrongDinhMuc.ReadOnly = true;
            this.txtTrongDinhMuc.Size = new System.Drawing.Size(100, 20);
            this.txtTrongDinhMuc.TabIndex = 23;
            // 
            // txtVuotDinhMuc
            // 
            this.txtVuotDinhMuc.Location = new System.Drawing.Point(223, 235);
            this.txtVuotDinhMuc.Name = "txtVuotDinhMuc";
            this.txtVuotDinhMuc.ReadOnly = true;
            this.txtVuotDinhMuc.Size = new System.Drawing.Size(100, 20);
            this.txtVuotDinhMuc.TabIndex = 24;
            // 
            // txtTongTienSD
            // 
            this.txtTongTienSD.Location = new System.Drawing.Point(223, 267);
            this.txtTongTienSD.Name = "txtTongTienSD";
            this.txtTongTienSD.ReadOnly = true;
            this.txtTongTienSD.Size = new System.Drawing.Size(100, 20);
            this.txtTongTienSD.TabIndex = 25;
            // 
            // txtTongTienVAT
            // 
            this.txtTongTienVAT.Location = new System.Drawing.Point(223, 309);
            this.txtTongTienVAT.Name = "txtTongTienVAT";
            this.txtTongTienVAT.ReadOnly = true;
            this.txtTongTienVAT.Size = new System.Drawing.Size(100, 20);
            this.txtTongTienVAT.TabIndex = 26;
            // 
            // txtTongTienPT
            // 
            this.txtTongTienPT.Location = new System.Drawing.Point(223, 354);
            this.txtTongTienPT.Name = "txtTongTienPT";
            this.txtTongTienPT.ReadOnly = true;
            this.txtTongTienPT.Size = new System.Drawing.Size(100, 20);
            this.txtTongTienPT.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(512, 142);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(201, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Nếu số nhân khẩu <  4 thì định mức = 12";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(512, 166);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(197, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Ngược lại: Định mức = số nhân khẩu x 4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtTongTienPT);
            this.Controls.Add(this.txtTongTienVAT);
            this.Controls.Add(this.txtTongTienSD);
            this.Controls.Add(this.txtVuotDinhMuc);
            this.Controls.Add(this.txtTrongDinhMuc);
            this.Controls.Add(this.txtTongMetKhoiSD);
            this.Controls.Add(this.txtChiSoMoi);
            this.Controls.Add(this.txtChiSoCu);
            this.Controls.Add(this.txtSoNhanKhau);
            this.Controls.Add(this.txtHoTenKH);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tính tiền nước";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox txtKQ;
        private System.Windows.Forms.TextBox txtHoTenKH;
        private System.Windows.Forms.TextBox txtSoNhanKhau;
        private System.Windows.Forms.TextBox txtChiSoCu;
        private System.Windows.Forms.TextBox txtChiSoMoi;
        private System.Windows.Forms.TextBox txtTongMetKhoiSD;
        private System.Windows.Forms.TextBox txtTrongDinhMuc;
        private System.Windows.Forms.TextBox txtVuotDinhMuc;
        private System.Windows.Forms.TextBox txtTongTienSD;
        private System.Windows.Forms.TextBox txtTongTienVAT;
        private System.Windows.Forms.TextBox txtTongTienPT;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}

