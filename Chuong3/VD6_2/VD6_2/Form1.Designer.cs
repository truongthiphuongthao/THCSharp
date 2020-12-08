namespace VD6_2
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
            this.btnCount = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnProper = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kết quả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập họ tên";
            // 
            // txbHoTen
            // 
            this.txbHoTen.Location = new System.Drawing.Point(173, 58);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.Size = new System.Drawing.Size(221, 20);
            this.txbHoTen.TabIndex = 2;
            // 
            // txbKQ
            // 
            this.txbKQ.Location = new System.Drawing.Point(173, 127);
            this.txbKQ.Name = "txbKQ";
            this.txbKQ.Size = new System.Drawing.Size(221, 96);
            this.txbKQ.TabIndex = 3;
            this.txbKQ.Text = "";
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(161, 270);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(100, 23);
            this.btnCount.TabIndex = 4;
            this.btnCount.Text = "CountOfWord";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(267, 270);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 5;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(360, 270);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnProper
            // 
            this.btnProper.Location = new System.Drawing.Point(161, 314);
            this.btnProper.Name = "btnProper";
            this.btnProper.Size = new System.Drawing.Size(75, 23);
            this.btnProper.TabIndex = 7;
            this.btnProper.Text = "Proper";
            this.btnProper.UseVisualStyleBackColor = true;
            this.btnProper.Click += new System.EventHandler(this.btnProper_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(267, 314);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 8;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnDung
            // 
            this.btnDung.Location = new System.Drawing.Point(360, 314);
            this.btnDung.Name = "btnDung";
            this.btnDung.Size = new System.Drawing.Size(75, 23);
            this.btnDung.TabIndex = 9;
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
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnProper);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.txbKQ);
            this.Controls.Add(this.txbHoTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Chuỗi họ và tên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbHoTen;
        private System.Windows.Forms.RichTextBox txbKQ;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnProper;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDung;
    }
}

