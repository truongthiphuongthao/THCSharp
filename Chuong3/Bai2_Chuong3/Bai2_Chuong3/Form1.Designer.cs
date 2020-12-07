namespace Bai2_Chuong3
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
            this.btnNhap = new System.Windows.Forms.Button();
            this.txbKQ = new System.Windows.Forms.RichTextBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(548, 119);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(84, 26);
            this.btnNhap.TabIndex = 1;
            this.btnNhap.Text = "Nhập mảng";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // txbKQ
            // 
            this.txbKQ.Location = new System.Drawing.Point(172, 127);
            this.txbKQ.Name = "txbKQ";
            this.txbKQ.Size = new System.Drawing.Size(353, 186);
            this.txbKQ.TabIndex = 2;
            this.txbKQ.Text = "";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(302, 319);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(84, 26);
            this.btnIn.TabIndex = 3;
            this.btnIn.Text = "In mảng";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnSapXep
            // 
            this.btnSapXep.Location = new System.Drawing.Point(548, 151);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(84, 79);
            this.btnSapXep.TabIndex = 4;
            this.btnSapXep.Text = "Sắp xếp";
            this.btnSapXep.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSapXep);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.txbKQ);
            this.Controls.Add(this.btnNhap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.RichTextBox txbKQ;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnSapXep;
    }
}

