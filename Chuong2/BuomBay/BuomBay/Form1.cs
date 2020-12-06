using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuomBay
{
    public partial class Form1 : Form
    {
        Image conbuom1, conbuom2;
        public Form1()
        {
            InitializeComponent();
            conbuom1 = Image.FromFile("conbuom.jpg");
            conbuom2 = Image.FromFile("conbuom2.png");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(conbuom.Image == conbuom1)
            {
                conbuom.Image = conbuom2;
            }
            else
            {
                conbuom.Image = conbuom1;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            conbuom.Left += 1;
          //  Console.WriteLine("Hello");
        }
    }
}
