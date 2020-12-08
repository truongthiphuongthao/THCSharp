namespace Bai1_Chuong3
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
            this.txbTen = new System.Windows.Forms.TextBox();
            this.txbSoNguyenTo = new System.Windows.Forms.TextBox();
            this.txbKQ = new System.Windows.Forms.RichTextBox();
            this.btnTen = new System.Windows.Forms.Button();
            this.btnSoNguyenTo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập họ và tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập số nguyên tố:";
            // 
            // txbTen
            // 
            this.txbTen.Location = new System.Drawing.Point(320, 32);
            this.txbTen.Name = "txbTen";
            this.txbTen.Size = new System.Drawing.Size(100, 20);
            this.txbTen.TabIndex = 2;
            // 
            // txbSoNguyenTo
            // 
            this.txbSoNguyenTo.Location = new System.Drawing.Point(320, 68);
            this.txbSoNguyenTo.Name = "txbSoNguyenTo";
            this.txbSoNguyenTo.Size = new System.Drawing.Size(100, 20);
            this.txbSoNguyenTo.TabIndex = 3;
            // 
            // txbKQ
            // 
            this.txbKQ.Location = new System.Drawing.Point(217, 118);
            this.txbKQ.Name = "txbKQ";
            this.txbKQ.Size = new System.Drawing.Size(267, 119);
            this.txbKQ.TabIndex = 4;
            this.txbKQ.Text = "";
            // 
            // btnTen
            // 
            this.btnTen.Location = new System.Drawing.Point(217, 265);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(75, 23);
            this.btnTen.TabIndex = 5;
            this.btnTen.Text = "Tên";
            this.btnTen.UseVisualStyleBackColor = true;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // btnSoNguyenTo
            // 
            this.btnSoNguyenTo.Location = new System.Drawing.Point(409, 265);
            this.btnSoNguyenTo.Name = "btnSoNguyenTo";
            this.btnSoNguyenTo.Size = new System.Drawing.Size(115, 23);
            this.btnSoNguyenTo.TabIndex = 6;
            this.btnSoNguyenTo.Text = "Số nguyên tố";
            this.btnSoNguyenTo.UseVisualStyleBackColor = true;
            this.btnSoNguyenTo.Click += new System.EventHandler(this.btnSoNguyenTo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSoNguyenTo);
            this.Controls.Add(this.btnTen);
            this.Controls.Add(this.txbKQ);
            this.Controls.Add(this.txbSoNguyenTo);
            this.Controls.Add(this.txbTen);
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
        private System.Windows.Forms.TextBox txbTen;
        private System.Windows.Forms.TextBox txbSoNguyenTo;
        private System.Windows.Forms.RichTextBox txbKQ;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Button btnSoNguyenTo;
    }
}

