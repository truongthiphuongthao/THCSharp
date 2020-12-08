namespace VD7_1
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
            this.txbHoTen = new System.Windows.Forms.TextBox();
            this.txbKQ = new System.Windows.Forms.RichTextBox();
            this.btnInLoiGioiThieu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHoaDauTu = new System.Windows.Forms.Button();
            this.btnDemTu = new System.Windows.Forms.Button();
            this.btnTen = new System.Windows.Forms.Button();
            this.btnHoLot = new System.Windows.Forms.Button();
            this.btnDung = new System.Windows.Forms.Button();
            this.btnInHoa = new System.Windows.Forms.Button();
            this.btnInThuong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập họ và tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kết quả:";
            // 
            // txbHoTen
            // 
            this.txbHoTen.Location = new System.Drawing.Point(245, 43);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.Size = new System.Drawing.Size(143, 20);
            this.txbHoTen.TabIndex = 2;
            // 
            // txbKQ
            // 
            this.txbKQ.Location = new System.Drawing.Point(170, 106);
            this.txbKQ.Name = "txbKQ";
            this.txbKQ.Size = new System.Drawing.Size(209, 96);
            this.txbKQ.TabIndex = 3;
            this.txbKQ.Text = "";
            // 
            // btnInLoiGioiThieu
            // 
            this.btnInLoiGioiThieu.Location = new System.Drawing.Point(130, 208);
            this.btnInLoiGioiThieu.Name = "btnInLoiGioiThieu";
            this.btnInLoiGioiThieu.Size = new System.Drawing.Size(90, 67);
            this.btnInLoiGioiThieu.TabIndex = 4;
            this.btnInLoiGioiThieu.Text = "In lời giới thiệu";
            this.btnInLoiGioiThieu.UseVisualStyleBackColor = true;
            this.btnInLoiGioiThieu.Click += new System.EventHandler(this.btnInLoiGioiThieu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(427, 253);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 22);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHoaDauTu
            // 
            this.btnHoaDauTu.Location = new System.Drawing.Point(322, 253);
            this.btnHoaDauTu.Name = "btnHoaDauTu";
            this.btnHoaDauTu.Size = new System.Drawing.Size(90, 22);
            this.btnHoaDauTu.TabIndex = 6;
            this.btnHoaDauTu.Text = "Hoa đầu từ";
            this.btnHoaDauTu.UseVisualStyleBackColor = true;
            this.btnHoaDauTu.Click += new System.EventHandler(this.btnHoaDauTu_Click);
            // 
            // btnDemTu
            // 
            this.btnDemTu.Location = new System.Drawing.Point(322, 208);
            this.btnDemTu.Name = "btnDemTu";
            this.btnDemTu.Size = new System.Drawing.Size(90, 22);
            this.btnDemTu.TabIndex = 7;
            this.btnDemTu.Text = "Đếm từ";
            this.btnDemTu.UseVisualStyleBackColor = true;
            this.btnDemTu.Click += new System.EventHandler(this.btnDemTu_Click);
            // 
            // btnTen
            // 
            this.btnTen.Location = new System.Drawing.Point(226, 253);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(90, 22);
            this.btnTen.TabIndex = 8;
            this.btnTen.Text = "Tên";
            this.btnTen.UseVisualStyleBackColor = true;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // btnHoLot
            // 
            this.btnHoLot.Location = new System.Drawing.Point(226, 208);
            this.btnHoLot.Name = "btnHoLot";
            this.btnHoLot.Size = new System.Drawing.Size(90, 22);
            this.btnHoLot.TabIndex = 9;
            this.btnHoLot.Text = "Họ lót";
            this.btnHoLot.UseVisualStyleBackColor = true;
            this.btnHoLot.Click += new System.EventHandler(this.btnHoLot_Click);
            // 
            // btnDung
            // 
            this.btnDung.Location = new System.Drawing.Point(427, 208);
            this.btnDung.Name = "btnDung";
            this.btnDung.Size = new System.Drawing.Size(90, 22);
            this.btnDung.TabIndex = 10;
            this.btnDung.Text = "Dừng";
            this.btnDung.UseVisualStyleBackColor = true;
            this.btnDung.Click += new System.EventHandler(this.btnDung_Click);
            // 
            // btnInHoa
            // 
            this.btnInHoa.Location = new System.Drawing.Point(523, 208);
            this.btnInHoa.Name = "btnInHoa";
            this.btnInHoa.Size = new System.Drawing.Size(90, 22);
            this.btnInHoa.TabIndex = 11;
            this.btnInHoa.Text = "In hoa";
            this.btnInHoa.UseVisualStyleBackColor = true;
            this.btnInHoa.Click += new System.EventHandler(this.btnInHoa_Click);
            // 
            // btnInThuong
            // 
            this.btnInThuong.Location = new System.Drawing.Point(523, 253);
            this.btnInThuong.Name = "btnInThuong";
            this.btnInThuong.Size = new System.Drawing.Size(90, 22);
            this.btnInThuong.TabIndex = 12;
            this.btnInThuong.Text = "In thường";
            this.btnInThuong.UseVisualStyleBackColor = true;
            this.btnInThuong.Click += new System.EventHandler(this.btnInThuong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInThuong);
            this.Controls.Add(this.btnInHoa);
            this.Controls.Add(this.btnDung);
            this.Controls.Add(this.btnHoLot);
            this.Controls.Add(this.btnTen);
            this.Controls.Add(this.btnDemTu);
            this.Controls.Add(this.btnHoaDauTu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnInLoiGioiThieu);
            this.Controls.Add(this.txbKQ);
            this.Controls.Add(this.txbHoTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbHoTen;
        private System.Windows.Forms.RichTextBox txbKQ;
        private System.Windows.Forms.Button btnInLoiGioiThieu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHoaDauTu;
        private System.Windows.Forms.Button btnDemTu;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Button btnHoLot;
        private System.Windows.Forms.Button btnDung;
        private System.Windows.Forms.Button btnInHoa;
        private System.Windows.Forms.Button btnInThuong;
    }
}

