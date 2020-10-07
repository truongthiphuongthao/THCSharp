namespace Bai5
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
            this.btnBT1 = new System.Windows.Forms.Button();
            this.btnBT2 = new System.Windows.Forms.Button();
            this.btnBT3 = new System.Windows.Forms.Button();
            this.btnBT4 = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBT1
            // 
            this.btnBT1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBT1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBT1.Location = new System.Drawing.Point(300, 12);
            this.btnBT1.Name = "btnBT1";
            this.btnBT1.Size = new System.Drawing.Size(139, 23);
            this.btnBT1.TabIndex = 0;
            this.btnBT1.Text = "Bài tập 1";
            this.btnBT1.UseVisualStyleBackColor = false;
            this.btnBT1.Click += new System.EventHandler(this.btnBT1_Click);
            // 
            // btnBT2
            // 
            this.btnBT2.BackColor = System.Drawing.Color.HotPink;
            this.btnBT2.Location = new System.Drawing.Point(300, 77);
            this.btnBT2.Name = "btnBT2";
            this.btnBT2.Size = new System.Drawing.Size(139, 23);
            this.btnBT2.TabIndex = 1;
            this.btnBT2.Text = "Bài tập 2";
            this.btnBT2.UseVisualStyleBackColor = false;
            this.btnBT2.Click += new System.EventHandler(this.btnBT2_Click);
            // 
            // btnBT3
            // 
            this.btnBT3.BackColor = System.Drawing.Color.BlueViolet;
            this.btnBT3.Location = new System.Drawing.Point(300, 136);
            this.btnBT3.Name = "btnBT3";
            this.btnBT3.Size = new System.Drawing.Size(139, 23);
            this.btnBT3.TabIndex = 2;
            this.btnBT3.Text = "Bài tập 3";
            this.btnBT3.UseVisualStyleBackColor = false;
            this.btnBT3.Click += new System.EventHandler(this.btnBT3_Click);
            // 
            // btnBT4
            // 
            this.btnBT4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBT4.Location = new System.Drawing.Point(300, 203);
            this.btnBT4.Name = "btnBT4";
            this.btnBT4.Size = new System.Drawing.Size(139, 23);
            this.btnBT4.TabIndex = 3;
            this.btnBT4.Text = "Bài tập 4";
            this.btnBT4.UseVisualStyleBackColor = false;
            this.btnBT4.Click += new System.EventHandler(this.btnBT4_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(300, 266);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(139, 23);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnBT4);
            this.Controls.Add(this.btnBT3);
            this.Controls.Add(this.btnBT2);
            this.Controls.Add(this.btnBT1);
            this.Name = "Form1";
            this.Text = "Các Bài Tập Thực Hành";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBT1;
        private System.Windows.Forms.Button btnBT2;
        private System.Windows.Forms.Button btnBT3;
        private System.Windows.Forms.Button btnBT4;
        private System.Windows.Forms.Button btnThoat;
    }
}

