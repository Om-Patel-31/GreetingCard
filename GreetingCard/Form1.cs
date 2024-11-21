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
            g.DrawString("Trick", font, brush, 230, 30);
            g.DrawString("Or", font, brush, 290, 140);
            g.DrawString("Treat", font, brush, 230, 230);

            //drawing a horror gravestone
            //drawing gravestone
            //lower base
            g.FillRectangle(brush, 230, 700, 250, 30);
            //upper base
            g.FillRectangle(brush, 255, 660, 200, 30);
            //the main remembrance
            g.FillRectangle(brush, 270, 480, 170, 170);
            //circle
            g.FillPie(brush, 270, 400, 170, 170, 180, 180);

            brush.Color = Color.FromArgb(255, 40, 40, 40);
            //drawing text on gravestone
            font = new Font("Midnight Minutes", 60);
            g.DrawString("RIP", font, brush, 295, 430);
            
            //drawing hand on gravestone
            g.FillRectangle(brush, 350, 560, 50, 40);
            // Fingers
            //index
            g.FillRectangle(brush, 350, 530, 7, 30);
            g.FillEllipse(brush, 349, 523, 8, 10);
            //middle
            g.FillRectangle(brush, 365, 520, 7, 40);
            g.FillEllipse(brush, 364, 518, 8, 10);
            //ring
            g.FillRectangle(brush, 380, 527, 7, 33);
            g.FillEllipse(brush, 379, 523, 8, 10);
            //pinky
            g.FillRectangle(brush, 393, 540, 7, 25);
            g.FillEllipse(brush, 392, 533, 8, 10);
            // Thumb
            pen.Color = Color.FromArgb(255, 40, 40, 40);
            g.DrawLine(pen, 335, 570, 355, 595);
            g.FillEllipse(brush, 330, 566, 10, 10);
            //arm length
            g.FillRectangle(brush, 360, 600, 30, 50);
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }
    }
}
