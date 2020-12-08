namespace Bai1_VD6
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
            this.txbHoTen = new System.Windows.Forms.TextBox();
            this.txbKQ = new System.Windows.Forms.RichTextBox();
            this.btnDoDai = new System.Windows.Forms.Button();
            this.btnChuThuong = new System.Windows.Forms.Button();
            this.btnInHoa = new System.Windows.Forms.Button();
            this.btnVietHoaDauTu = new System.Windows.Forms.Button();
            this.btnLoaiBoKhoangTrangThua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập họ và tên";
            // 
            // txbHoTen
            // 
            this.txbHoTen.Location = new System.Drawing.Point(224, 41);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.Size = new System.Drawing.Size(189, 20);
            this.txbHoTen.TabIndex = 1;
            // 
            // txbKQ
            // 
            this.txbKQ.Location = new System.Drawing.Point(224, 107);
            this.txbKQ.Name = "txbKQ";
            this.txbKQ.Size = new System.Drawing.Size(189, 139);
            this.txbKQ.TabIndex = 2;
            this.txbKQ.Text = "";
            // 
            // btnDoDai
            // 
            this.btnDoDai.Location = new System.Drawing.Point(148, 276);
            this.btnDoDai.Name = "btnDoDai";
            this.btnDoDai.Size = new System.Drawing.Size(110, 23);
            this.btnDoDai.TabIndex = 3;
            this.btnDoDai.Text = "Độ dài và số từ";
            this.btnDoDai.UseVisualStyleBackColor = true;
            this.btnDoDai.Click += new System.EventHandler(this.btnDoDai_Click);
            // 
            // btnChuThuong
            // 
            this.btnChuThuong.Location = new System.Drawing.Point(268, 276);
            this.btnChuThuong.Name = "btnChuThuong";
            this.btnChuThuong.Size = new System.Drawing.Size(75, 23);
            this.btnChuThuong.TabIndex = 4;
            this.btnChuThuong.Text = "Chữ thường";
            this.btnChuThuong.UseVisualStyleBackColor = true;
            this.btnChuThuong.Click += new System.EventHandler(this.btnChuThuong_Click);
            // 
            // btnInHoa
            // 
            this.btnInHoa.Location = new System.Drawing.Point(349, 276);
            this.btnInHoa.Name = "btnInHoa";
            this.btnInHoa.Size = new System.Drawing.Size(75, 23);
            this.btnInHoa.TabIndex = 5;
            this.btnInHoa.Text = "In hoa";
            this.btnInHoa.UseVisualStyleBackColor = true;
            this.btnInHoa.Click += new System.EventHandler(this.btnInHoa_Click);
            // 
            // btnVietHoaDauTu
            // 
            this.btnVietHoaDauTu.Location = new System.Drawing.Point(430, 276);
            this.btnVietHoaDauTu.Name = "btnVietHoaDauTu";
            this.btnVietHoaDauTu.Size = new System.Drawing.Size(93, 23);
            this.btnVietHoaDauTu.TabIndex = 6;
            this.btnVietHoaDauTu.Text = "Viết hoa đầu từ";
            this.btnVietHoaDauTu.UseVisualStyleBackColor = true;
            this.btnVietHoaDauTu.Click += new System.EventHandler(this.btnVietHoaDauTu_Click);
            // 
            // btnLoaiBoKhoangTrangThua
            // 
            this.btnLoaiBoKhoangTrangThua.Location = new System.Drawing.Point(529, 276);
            this.btnLoaiBoKhoangTrangThua.Name = "btnLoaiBoKhoangTrangThua";
            this.btnLoaiBoKhoangTrangThua.Size = new System.Drawing.Size(180, 23);
            this.btnLoaiBoKhoangTrangThua.TabIndex = 7;
            this.btnLoaiBoKhoangTrangThua.Text = "Loại bỏ các khoảng trắng thừa";
            this.btnLoaiBoKhoangTrangThua.UseVisualStyleBackColor = true;
            this.btnLoaiBoKhoangTrangThua.Click += new System.EventHandler(this.btnLoaiBoKhoangTrangThua_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoaiBoKhoangTrangThua);
            this.Controls.Add(this.btnVietHoaDauTu);
            this.Controls.Add(this.btnInHoa);
            this.Controls.Add(this.btnChuThuong);
            this.Controls.Add(this.btnDoDai);
            this.Controls.Add(this.txbKQ);
            this.Controls.Add(this.txbHoTen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbHoTen;
        private System.Windows.Forms.RichTextBox txbKQ;
        private System.Windows.Forms.Button btnDoDai;
        private System.Windows.Forms.Button btnChuThuong;
        private System.Windows.Forms.Button btnInHoa;
        private System.Windows.Forms.Button btnVietHoaDauTu;
        private System.Windows.Forms.Button btnLoaiBoKhoangTrangThua;
    }
}

