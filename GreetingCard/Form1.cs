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
            SolidBrush brush = new SolidBrush(Color.Orange);
            Font font = new Font("Midnight Minutes", 80);

            //drawing trick or treat
            g.DrawString("Trick", font, brush, 230, 30);
            g.DrawString("Or", font, brush, 290, 140);
            g.DrawString("Treat", font, brush, 230, 230);

            //drawing a horror gravestone
            //drawing gravestone
            //lower base
            brush.Color = Color.White;
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
            brush.Color = Color.FromArgb(255, 229, 57, 53);
            g.DrawString("RIP", font, brush, 295, 430);

            //drawing hand on gravestone
            //palm
            brush.Color = Color.FromArgb(255, 104, 159, 56);
            g.FillRectangle(brush, 350, 560, 50, 40);
            g.FillPie(brush, 350, 585, 30, 20, 75, 120);
            g.FillPie(brush, 370, 587, 30, 20, 90, -100);
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
            pen.Color = Color.FromArgb(255, 104, 159, 56);
            g.DrawLine(pen, 335, 570, 355, 595);
            g.FillEllipse(brush, 330, 566, 10, 10);
            //arm
            g.FillRectangle(brush, 355, 600, 40, 130);
            brush.Color = Color.FromArgb(255, 229, 57, 53);
            g.FillPie(brush, 387, 610, 15, 20, 90, 180);
            g.FillPie(brush, 390, 615, 10, 25, 90, 180);
            g.FillPie(brush, 345, 650, 20, 30, -90, 180);
            g.FillPie(brush, 350, 670, 20, 10, -90, 180);
            //soil for realistic effect
            //for depth
            brush.Color = Color.FromArgb(255, 62, 39, 35);
            g.FillPie(brush, 415, 730, 60, 60, -180, 180);
            g.FillPie(brush, 387, 715, 60, 80, -180, 180);
            g.FillPie(brush, 365, 708, 60, 85, -180, 180);
            g.FillPie(brush, 345, 700, 60, 90, -180, 180);
            g.FillPie(brush, 325, 708, 60, 85, -180, 180);
            g.FillPie(brush, 303, 715, 60, 80, -180, 180);
            g.FillPie(brush, 280, 730, 60, 60, -180, 180);
            //inner
            brush.Color = Color.FromArgb(255, 93, 64, 55);
            g.FillPie(brush, 410, 735, 50, 50, -180, 180);
            g.FillPie(brush, 390, 720, 50, 80, -180, 180);
            g.FillPie(brush, 370, 715, 50, 85, -180, 180);
            g.FillPie(brush, 350, 710, 50, 90, -180, 180);
            g.FillPie(brush, 330, 715, 50, 85, -180, 180);
            g.FillPie(brush, 310, 720, 50, 80, -180, 180);
            g.FillPie(brush, 290, 735, 50, 50, -180, 180);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            //declaring pen, brush and font
            Pen pen = new Pen(Color.White, 10);
            SolidBrush brush = new SolidBrush(Color.White);
            Font font = new Font("October Crow", 60);

            //Clearing the screen
            Refresh();
            g.Clear(Color.FromArgb(255, 40, 40, 40));

            //drawing halloween greeting
            g.DrawString("Happy Halloween!", font, brush, 80, 50);

            //drawing

            //drawing pumpkin
            brush.Color = Color.FromArgb(255, 255, 98, 0);
            g.FillEllipse(brush, 260, 580, 70, 140);
            g.FillEllipse(brush, 380, 580, 70, 140);
            brush.Color = Color.FromArgb(255, 255, 111, 0);
            g.FillEllipse(brush, 355, 580, 70, 145);
            g.FillEllipse(brush, 285, 580, 70, 145);
            brush.Color = Color.FromArgb(255, 255, 135, 7);
            g.FillEllipse(brush, 320, 580, 70, 150);
            pen.Width = 20;
            pen.Color = Color.FromArgb(255, 4, 125, 0);
            brush.Color = Color.FromArgb(255, 4, 125, 0);
            g.DrawLine(pen, 355, 590, 355, 550);
            g.FillPie(brush, 320, 564, 70, 30, 45, 90);

            //making pumpkin's expression
            brush.Color = Color.Black;
            //right eye
            //g.FillPie(brush, 290, 600, 50, 50, 50, 180);
            g.FillPie(brush, 290, 600, 50, 50, 180, 360);
            brush.Color = Color.White;
            g.FillPie(brush, 295, 605, 30, 30, 180, 360);
            //left eye
            //evil eye
            //g.FillPie(brush, 370, 600, 50, 50, -50, 180);
            brush.Color = Color.Black;
            g.FillPie(brush, 370, 600, 50, 50, 180, 360);
            brush.Color = Color.White;
            g.FillPie(brush, 375, 605, 30, 30, 180, 360);
            //nose
            brush.Color = Color.Black;
            g.FillPie(brush, 330, 620, 50, 40, 60, 65);
            //mouth
            g.FillPie(brush, 320, 640, 70, 70, 0, 180);
            //brush.Color = Color.FromArgb(255, 255, 135, 7);
            //g.FillRectangle(brush, 335, 670, 13, 13);
            //g.FillRectangle(brush, 360, 670, 13, 13);
        }
    }
}