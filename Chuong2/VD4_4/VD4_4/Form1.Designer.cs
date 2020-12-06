namespace VD4_4
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnBD = new System.Windows.Forms.Button();
            this.btnDung = new System.Windows.Forms.Button();
            this.lblDongHo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnBD
            // 
            this.btnBD.Location = new System.Drawing.Point(28, 83);
            this.btnBD.Name = "btnBD";
            this.btnBD.Size = new System.Drawing.Size(84, 44);
            this.btnBD.TabIndex = 0;
            this.btnBD.Text = "Bắt đầu";
            this.btnBD.UseVisualStyleBackColor = true;
            this.btnBD.Click += new System.EventHandler(this.btnBD_Click);
            // 
            // btnDung
            // 
            this.btnDung.Location = new System.Drawing.Point(228, 83);
            this.btnDung.Name = "btnDung";
            this.btnDung.Size = new System.Drawing.Size(84, 44);
            this.btnDung.TabIndex = 1;
            this.btnDung.Text = "Dừng";
            this.btnDung.UseVisualStyleBackColor = true;
            this.btnDung.Click += new System.EventHandler(this.btnDung_Click);
            // 
            // lblDongHo
            // 
            this.lblDongHo.AutoSize = true;
            this.lblDongHo.Location = new System.Drawing.Point(142, 55);
            this.lblDongHo.Name = "lblDongHo";
            this.lblDongHo.Size = new System.Drawing.Size(0, 13);
            this.lblDongHo.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 261);
            this.Controls.Add(this.lblDongHo);
            this.Controls.Add(this.btnDung);
            this.Controls.Add(this.btnBD);
            this.Name = "Form1";
            this.Text = "Đồng hồ đếm ngược";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnBD;
        private System.Windows.Forms.Button btnDung;
        private System.Windows.Forms.Label lblDongHo;
    }
}

