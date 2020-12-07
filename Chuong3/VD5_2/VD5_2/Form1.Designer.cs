namespace VD5_2
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
            this.btnNhapMang = new System.Windows.Forms.Button();
            this.txtnhap = new System.Windows.Forms.TextBox();
            this.btnInMang = new System.Windows.Forms.Button();
            this.btnSapGiam = new System.Windows.Forms.Button();
            this.btnSapTang = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDung = new System.Windows.Forms.Button();
            this.txbKQ = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnNhapMang
            // 
            this.btnNhapMang.Location = new System.Drawing.Point(168, 69);
            this.btnNhapMang.Name = "btnNhapMang";
            this.btnNhapMang.Size = new System.Drawing.Size(208, 23);
            this.btnNhapMang.TabIndex = 0;
            this.btnNhapMang.Text = "Nhập 1 phần tử mảng";
            this.btnNhapMang.UseVisualStyleBackColor = true;
            this.btnNhapMang.Click += new System.EventHandler(this.btnNhapMang_Click);
            // 
            // txtnhap
            // 
            this.txtnhap.Location = new System.Drawing.Point(382, 72);
            this.txtnhap.Name = "txtnhap";
            this.txtnhap.Size = new System.Drawing.Size(144, 20);
            this.txtnhap.TabIndex = 1;
            // 
            // btnInMang
            // 
            this.btnInMang.Location = new System.Drawing.Point(191, 279);
            this.btnInMang.Name = "btnInMang";
            this.btnInMang.Size = new System.Drawing.Size(75, 23);
            this.btnInMang.TabIndex = 2;
            this.btnInMang.Text = "In mảng";
            this.btnInMang.UseVisualStyleBackColor = true;
            this.btnInMang.Click += new System.EventHandler(this.btnInMang_Click);
            // 
            // btnSapGiam
            // 
            this.btnSapGiam.Location = new System.Drawing.Point(522, 196);
            this.btnSapGiam.Name = "btnSapGiam";
            this.btnSapGiam.Size = new System.Drawing.Size(75, 77);
            this.btnSapGiam.TabIndex = 3;
            this.btnSapGiam.Text = "Sắp giảm";
            this.btnSapGiam.UseVisualStyleBackColor = true;
            this.btnSapGiam.Click += new System.EventHandler(this.btnSapGiam_Click);
            // 
            // btnSapTang
            // 
            this.btnSapTang.Location = new System.Drawing.Point(522, 98);
            this.btnSapTang.Name = "btnSapTang";
            this.btnSapTang.Size = new System.Drawing.Size(75, 74);
            this.btnSapTang.TabIndex = 4;
            this.btnSapTang.Text = "Sắp tăng";
            this.btnSapTang.UseVisualStyleBackColor = true;
            this.btnSapTang.Click += new System.EventHandler(this.btnSapTang_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(301, 279);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDung
            // 
            this.btnDung.Location = new System.Drawing.Point(426, 279);
            this.btnDung.Name = "btnDung";
            this.btnDung.Size = new System.Drawing.Size(75, 23);
            this.btnDung.TabIndex = 6;
            this.btnDung.Text = "Dừng";
            this.btnDung.UseVisualStyleBackColor = true;
            this.btnDung.Click += new System.EventHandler(this.btnDung_Click);
            // 
            // txbKQ
            // 
            this.txbKQ.Location = new System.Drawing.Point(168, 98);
            this.txbKQ.Name = "txbKQ";
            this.txbKQ.Size = new System.Drawing.Size(358, 175);
            this.txbKQ.TabIndex = 7;
            this.txbKQ.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbKQ);
            this.Controls.Add(this.btnDung);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSapTang);
            this.Controls.Add(this.btnSapGiam);
            this.Controls.Add(this.btnInMang);
            this.Controls.Add(this.txtnhap);
            this.Controls.Add(this.btnNhapMang);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNhapMang;
        private System.Windows.Forms.TextBox txtnhap;
        private System.Windows.Forms.Button btnInMang;
        private System.Windows.Forms.Button btnSapGiam;
        private System.Windows.Forms.Button btnSapTang;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDung;
        private System.Windows.Forms.RichTextBox txbKQ;
    }
}

