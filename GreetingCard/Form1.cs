using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
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
            Font font = new Font("Trebuchet MS", 60);

            ////sound player
            SoundPlayer treatPlayer = new SoundPlayer(Properties.Resources.halloweenTreat);
            SoundPlayer ghostPlayer = new SoundPlayer(Properties.Resources.ghost);

            SoundPlayer batPlayer = new SoundPlayer(Properties.Resources.batVoice);

            ////Clearing the screen
            Refresh();
            g.Clear(Color.FromArgb(255, 40, 40, 40));

            Thread.Sleep(1000);
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

            //drawing treat to trick them to fall for it
            font = new Font("Trebuchet MS", 100);
            brush.Color = Color.White;
            g.DrawString("TREAT!", font, brush, 130, 100);

            //making pumpkin's expression
            brush.Color = Color.Black;
            //right eye
            g.FillPie(brush, 290, 600, 50, 50, 180, 360);
            brush.Color = Color.White;
            g.FillPie(brush, 295, 605, 30, 30, 180, 360);
            //left eye
            brush.Color = Color.Black;
            g.FillPie(brush, 370, 600, 50, 50, 180, 360);
            brush.Color = Color.White;
            g.FillPie(brush, 375, 605, 30, 30, 180, 360);
            //nose
            brush.Color = Color.Black;
            g.FillPie(brush, 330, 620, 50, 40, 60, 65);
            //mouth
            g.FillPie(brush, 320, 640, 70, 70, 0, 180);

            //candy border
            brush.Color = Color.White;
            g.FillEllipse(brush, 297, 347, 105, 105);
            //candy
            brush.Color = Color.Red;
            g.FillEllipse(brush, 300, 350, 100, 100);
            brush.Color = Color.White;
            g.FillPie(brush, 255, 355, 90, 100, 90, 150);
            g.FillPie(brush, 355, 345, 90, 100, -90, 150);
            pen.Width = 3;
            pen.Color = Color.White;
            //detailing
            pen.Width = 25;
            g.DrawLine(pen, 300, 410, 400, 390);
            brush.Color = Color.Red;
            g.FillEllipse(brush, 305, 400, 15, 15);
            g.FillEllipse(brush, 325, 397, 15, 15);
            g.FillEllipse(brush, 345, 393, 15, 15);
            g.FillEllipse(brush, 365, 389, 15, 15);
            g.FillEllipse(brush, 383, 385, 15, 15);

            treatPlayer.Play();

            //making it sleep before tricking them
            Thread.Sleep(3000);

            g.Clear(Color.FromArgb(255, 40, 40, 40));
            brush.Color = Color.White;
            //drawing text
            font = new Font("October Crow", 100);
            g.DrawString("Trick!", font, brush, 170, 100);

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
            //drawing it's expressions
            //right eye
            brush.Color = Color.Black;
            g.FillPie(brush, 290, 600, 50, 50, 50, 180);
            //left eye
            g.FillPie(brush, 370, 600, 50, 50, -50, 180);
            //nose
            g.FillPie(brush, 330, 620, 50, 40, 60, 65);
            //mouth
            g.FillPie(brush, 320, 640, 70, 70, 0, 180);
            brush.Color = Color.FromArgb(255, 255, 135, 7);
            g.FillRectangle(brush, 335, 670, 13, 13);
            g.FillRectangle(brush, 360, 670, 13, 13);

            //ghost
            brush.Color = Color.WhiteSmoke;
            //variables
            int mainCircleX = 500;
            int mainRectangleX = 500;
            int whiteCircle1X = 500;
            int whiteCircle2X = 545;
            int whiteCircle3X = 595;
            int grayCircle1X = 525;
            int grayCircle2X = 575;
            int rightEyeX = 515;
            int leftEyeX = 565;
            int mouthX = 545;
            //figure
            g.FillEllipse(brush, mainCircleX, 300, 125, 100); //ghost figure circle
            g.FillRectangle(brush, mainRectangleX, 350, 125, 125); //ghost figure square
            g.FillEllipse(brush, whiteCircle1X, 460, 30, 30); //ghost white first circle
            g.FillEllipse(brush, whiteCircle2X, 460, 30, 30); //ghost white second circle
            g.FillEllipse(brush, whiteCircle3X, 460, 30, 30); //ghost white third circle
            brush.Color = Color.FromArgb(255, 40, 40, 40);
            g.FillEllipse(brush, grayCircle1X, 460, 20, 30); //ghost gray first oval
            g.FillEllipse(brush, grayCircle2X, 460, 20, 30); //ghost gray second oval
            //expressions
            brush.Color = Color.Black;
            g.FillPie(brush, rightEyeX, 330, 40, 40, 50, 180); //ghost right eye
            g.FillPie(brush, leftEyeX, 330, 40, 40, -50, 180); //ghost left eye
            g.FillEllipse(brush, mouthX, 370, 30, 40); //ghost mouth

            Thread.Sleep(100);
            ghostPlayer.Play();
            //while loop for animating pumpkin and ghost
            while ((mainCircleX > 20) && (mainRectangleX > 20) && (whiteCircle1X > 20) && (whiteCircle2X > 20) && (whiteCircle3X > 20) && (grayCircle1X > 20) && (grayCircle2X > 20) && (rightEyeX > 20) && (leftEyeX > 20) && (mouthX > 20))
            {
                Thread.Sleep(500);
                mainCircleX -= 20;
                mainRectangleX -= 20;
                whiteCircle1X -= 20;
                whiteCircle2X -= 20;
                whiteCircle3X -= 20;
                grayCircle1X -= 20;
                grayCircle2X -= 20;
                rightEyeX -= 20;
                leftEyeX -= 20;
                mouthX -= 20;
                Refresh();

                brush.Color = Color.White;
                //drawing text
                font = new Font("October Crow", 100);
                g.DrawString("Trick!", font, brush, 170, 100);

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
                //drawing it's expressions
                //right eye
                brush.Color = Color.Black;
                g.FillPie(brush, 290, 600, 50, 50, 50, 180);
                //left eye
                g.FillPie(brush, 370, 600, 50, 50, -50, 180);
                //nose
                g.FillPie(brush, 330, 620, 50, 40, 60, 65);
                //mouth
                g.FillPie(brush, 320, 640, 70, 70, 0, 180);
                brush.Color = Color.FromArgb(255, 255, 135, 7);
                g.FillRectangle(brush, 335, 670, 13, 13);
                g.FillRectangle(brush, 360, 670, 13, 13);

                //figure
                brush.Color = Color.White;
                g.FillEllipse(brush, mainCircleX, 300, 125, 100); //ghost figure circle
                g.FillRectangle(brush, mainRectangleX, 350, 125, 125); //ghost figure square
                g.FillEllipse(brush, whiteCircle1X, 460, 30, 30); //ghost white first circle
                g.FillEllipse(brush, whiteCircle2X, 460, 30, 30); //ghost white second circle
                g.FillEllipse(brush, whiteCircle3X, 460, 30, 30); //ghost white third circle
                brush.Color = Color.FromArgb(255, 40, 40, 40);
                g.FillEllipse(brush, grayCircle1X, 460, 20, 30); //ghost gray first oval
                g.FillEllipse(brush, grayCircle2X, 460, 20, 30); //ghost gray second oval
                                                                 //expressions
                brush.Color = Color.Black;
                g.FillPie(brush, rightEyeX, 330, 40, 40, 50, 180); //ghost right eye
                g.FillPie(brush, leftEyeX, 330, 40, 40, -50, 180); //ghost left eye
                g.FillEllipse(brush, mouthX, 370, 30, 40); //ghost mouth

                //changing pumpkin's expression colors
                Random rand = new Random();
                int red, green, blue;

                // Generate a color that is not orange
                while (1 > 0)
                {
                    red = rand.Next(0, 256);
                    green = rand.Next(0, 256);
                    blue = rand.Next(0, 256);

                    // Check if the color is not orange
                    if (!(red > 200 && green > 100 && green == 200 && blue == 100))
                        break;
                }

                brush.Color = Color.FromArgb(255, red, green, blue);
                g.FillPie(brush, 290, 600, 50, 50, 50, 180); // left eye
                g.FillPie(brush, 370, 600, 50, 50, -50, 180); // right eye
                g.FillPie(brush, 330, 620, 50, 40, 60, 65); // nose
                g.FillPie(brush, 320, 640, 70, 70, 0, 180);//mouth
                brush.Color = Color.FromArgb(255, 255, 135, 7);
                //editing mouth shapes
                g.FillRectangle(brush, 335, 670, 13, 13);
                g.FillRectangle(brush, 360, 670, 13, 13);
            }
            Refresh();

            brush.Color = Color.White;
            font = new Font("Midnight Minutes", 80);
            g.DrawString("Happy", font, brush, 210, 250);
            g.DrawString("Halloween", font, brush, 150, 370);

            //bat
            brush.Color = Color.Black;
            //face
            g.FillEllipse(brush, 80, 50, 25, 25);
            //ear (left)
            g.FillEllipse(brush, 77, 43, 10, 20);
            //ear (right)
            g.FillEllipse(brush, 97, 43, 10, 20);
            //body
            g.FillEllipse(brush, 77, 70, 30, 40);
            g.FillPie(brush, 77, 95, 30, 40, 220, 100);
            //wing (left)
            g.FillEllipse(brush, 10, 60, 90, 30);
            brush.Color = Color.FromArgb(255, 40, 40, 40);
            g.FillEllipse(brush, 7, 75, 20, 15);
            g.FillEllipse(brush, 27, 80, 25, 15);
            g.FillEllipse(brush, 55, 85, 23, 15);
            //wing (right)
            brush.Color = Color.Black;
            g.FillEllipse(brush, 80, 60, 90, 30);
            brush.Color = Color.FromArgb(255, 40, 40, 40);
            g.FillEllipse(brush, 152, 75, 20, 15);
            g.FillEllipse(brush, 129, 80, 25, 15);
            g.FillEllipse(brush, 105, 85, 23, 15);
            batPlayer.Play();
        }
    }
}