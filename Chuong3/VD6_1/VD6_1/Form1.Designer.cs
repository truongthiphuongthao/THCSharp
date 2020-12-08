namespace VD6_1
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
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbChuoi1 = new System.Windows.Forms.TextBox();
            this.txbChuoi2 = new System.Windows.Forms.TextBox();
            this.txbKQ = new System.Windows.Forms.RichTextBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnConcat = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCompareIn = new System.Windows.Forms.Button();
            this.btnIndexOf = new System.Windows.Forms.Button();
            this.btnSubstring = new System.Windows.Forms.Button();
            this.btnDung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.Location = new System.Drawing.Point(302, 24);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(162, 13);
            this.lbTieuDe.TabIndex = 0;
            this.lbTieuDe.Text = "CHƯƠNG TRÌNH XỬ LÝ CHUỖI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập vào chuỗi thứ nhất:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập vào chuỗi thứ hai:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kết quả:";
            // 
            // txbChuoi1
            // 
            this.txbChuoi1.Location = new System.Drawing.Point(212, 75);
            this.txbChuoi1.Name = "txbChuoi1";
            this.txbChuoi1.Size = new System.Drawing.Size(260, 20);
            this.txbChuoi1.TabIndex = 4;
            // 
            // txbChuoi2
            // 
            this.txbChuoi2.Location = new System.Drawing.Point(212, 142);
            this.txbChuoi2.Name = "txbChuoi2";
            this.txbChuoi2.Size = new System.Drawing.Size(260, 20);
            this.txbChuoi2.TabIndex = 5;
            // 
            // txbKQ
            // 
            this.txbKQ.Location = new System.Drawing.Point(186, 210);
            this.txbKQ.Name = "txbKQ";
            this.txbKQ.Size = new System.Drawing.Size(340, 144);
            this.txbKQ.TabIndex = 6;
            this.txbKQ.Text = "";
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(189, 383);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 7;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnConcat
            // 
            this.btnConcat.Location = new System.Drawing.Point(270, 383);
            this.btnConcat.Name = "btnConcat";
            this.btnConcat.Size = new System.Drawing.Size(75, 23);
            this.btnConcat.TabIndex = 8;
            this.btnConcat.Text = "Concat";
            this.btnConcat.UseVisualStyleBackColor = true;
            this.btnConcat.Click += new System.EventHandler(this.btnConcat_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(351, 383);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(432, 383);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCompareIn
            // 
            this.btnCompareIn.Location = new System.Drawing.Point(189, 415);
            this.btnCompareIn.Name = "btnCompareIn";
            this.btnCompareIn.Size = new System.Drawing.Size(75, 23);
            this.btnCompareIn.TabIndex = 11;
            this.btnCompareIn.Text = "COMPARE";
            this.btnCompareIn.UseVisualStyleBackColor = true;
            this.btnCompareIn.Click += new System.EventHandler(this.btnCompareIn_Click);
            // 
            // btnIndexOf
            // 
            this.btnIndexOf.Location = new System.Drawing.Point(270, 412);
            this.btnIndexOf.Name = "btnIndexOf";
            this.btnIndexOf.Size = new System.Drawing.Size(75, 23);
            this.btnIndexOf.TabIndex = 12;
            this.btnIndexOf.Text = "IndexOf";
            this.btnIndexOf.UseVisualStyleBackColor = true;
            this.btnIndexOf.Click += new System.EventHandler(this.btnIndexOf_Click);
            // 
            // btnSubstring
            // 
            this.btnSubstring.Location = new System.Drawing.Point(351, 415);
            this.btnSubstring.Name = "btnSubstring";
            this.btnSubstring.Size = new System.Drawing.Size(75, 23);
            this.btnSubstring.TabIndex = 13;
            this.btnSubstring.Text = "Substring";
            this.btnSubstring.UseVisualStyleBackColor = true;
            this.btnSubstring.Click += new System.EventHandler(this.btnSubstring_Click);
            // 
            // btnDung
            // 
            this.btnDung.Location = new System.Drawing.Point(432, 415);
            this.btnDung.Name = "btnDung";
            this.btnDung.Size = new System.Drawing.Size(75, 23);
            this.btnDung.TabIndex = 14;
            this.btnDung.Text = "Dừng";
            this.btnDung.UseVisualStyleBackColor = true;
            this.btnDung.Click += new System.EventHandler(this.btnDung_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDung);
            this.Controls.Add(this.btnSubstring);
            this.Controls.Add(this.btnIndexOf);
            this.Controls.Add(this.btnCompareIn);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnConcat);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.txbKQ);
            this.Controls.Add(this.txbChuoi2);
            this.Controls.Add(this.txbChuoi1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTieuDe);
            this.Name = "Form1";
            this.Text = "Xử lý chuỗi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbChuoi1;
        private System.Windows.Forms.TextBox txbChuoi2;
        private System.Windows.Forms.RichTextBox txbKQ;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnConcat;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCompareIn;
        private System.Windows.Forms.Button btnIndexOf;
        private System.Windows.Forms.Button btnSubstring;
        private System.Windows.Forms.Button btnDung;
    }
}

