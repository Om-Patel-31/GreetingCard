using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreetingCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            //declaring pen, brush and font
            Pen pen = new Pen(Color.White, 10);
            SolidBrush brush = new SolidBrush(Color.White);
            Font font = new Font("Midnight Minutes", 80);

            //drawing trick or treat
            g.DrawString("Trick", font, brush, 230, 10);
            g.DrawString("Or", font, brush, 290, 120);
            g.DrawString("Treat", font, brush, 230, 210);

            //drawing a horror gravestone
            g.FillRectangle(brush, 230, 700, 250, 30);
            g.FillRectangle(brush, 255, 660, 200, 30);
            g.FillRectangle(brush, 270, 480, 170, 170);
            g.FillPie(brush, 270, 400, 170, 170, 180, 180);
            brush.Color = Color.FromArgb(255, 40, 40, 40);
            font = new Font("Midnight Minutes", 60);
            g.DrawString("RIP", font, brush, 290, 450);
        }
    }
}
