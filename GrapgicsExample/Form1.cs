using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrapgicsExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Text = "Graphics";

            Graphics g = this.CreateGraphics();



            Font ikeaFont = new Font("Impact", 110, FontStyle.Bold);
            Font trademarkFont = new Font("Microsoft Yi Baiti", 10, FontStyle.Bold);

            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush blackBrush = new SolidBrush(Color.Black);




            g.FillRectangle(blueBrush, 30, 30, 500, 200);
            g.FillEllipse(yellowBrush, 30, 30, 500, 200);
            g.DrawString("I K E A", ikeaFont, blueBrush, 80, 35);

            g.TranslateTransform(471, 100);
            g.RotateTransform(82);
            g.DrawString("Trademark", trademarkFont, blackBrush, 0,10 );
            
        }
    }
}
