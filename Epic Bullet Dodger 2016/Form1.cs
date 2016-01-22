﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epic_Bullet_Dodger_2016
{
    public partial class Form1 : Form
    {

        //determines whether a key is being pressed or not
        Boolean downArrowDown, upArrowDown;
        
        // creates grphic forms
        SolidBrush drawbrush = new SolidBrush(Color.AliceBlue);
        SolidBrush drawbrush2 = new SolidBrush(Color.Red);

        //initial starting point
        int drawX = 155;
        int drawY = 155;
        int drawX2 = 500;
        int drawY2 = 300;
        int drawX3 = 750;
        int drawY3 = 200;
        int drawX4 = 1000;
        int drawY4 = 100;
        int drawX5 = 1050;
        int drawY5 = 400;
        int drawX6 = 1150;
        int drawY6 = 500;
        int drawX7 = 500;
        int drawY7 = 50;
        int speed = 1;
        int speed2 = 1;
        int speed3 = 1;
        int speed4 = 1;
        int speed5 = 1;
        int speed6 = 1;
        int counter = 1;
        int score = 0;

        public Form1()
        {
            InitializeComponent();


        }

        private void quitButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void playButton1_Click(object sender, EventArgs e)
        {

            //making labels invisible to play game
            epicLabel1.Visible = false;
            label1.Visible = false;
            playButton1.Visible = false;
            quitButton1.Visible = false;

            // start the timer when the program starts
            gametimer.Enabled = true;
            gametimer.Start();

            this.Focus();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //check to see if a key is pressed and set is KeyDown value to true if it has
            switch (e.KeyCode)
            {
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
               

            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //check to see if a key has been released and set its KeyDown value to false if it has
            switch (e.KeyCode)
            {
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;

            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //character movements
            if (downArrowDown == true)
            {
                drawY += 10;
            }
            if (upArrowDown == true)
            {
                drawY -= 10;
            }

            //bullet movements
            drawX2 -= speed;
            drawX3 -= speed2;
            drawX4 -= speed3;
            drawX5 -= speed4;
            drawX6 -= speed5;
            drawX7 -= speed6;
            //check if bullet is off screen
            if (drawX2 < 0)
            {
                drawX2 = 500;
                speed++;
                score++;
            }

            if (drawX3 < 0)
            {
                drawX3 = 600;
                speed2++;
            }

            if (drawX4 < 0)
            {
                drawX4 = 800;
                speed3++;
            }

            if (drawX5 < 0)
            {
                drawX5 = 600;
                speed4++;
            }

            if (drawX6 < 0)
            {
                drawX6 = 500;
                speed5++;
            }

            if (drawX7 < 0)
            {
                drawX7 = 700;
                speed6++;
            }

            //check for collision
            double distance = Math.Pow(drawX2 - drawX, 2) + Math.Pow(drawY2 - drawY, 2);
            if (distance < 40)
            {
                playButton1.Visible = true;
                quitButton1.Visible = true;
                playButton1.Text = "Play Again?";
                gametimer.Enabled = false;
                speed = 1;
                drawY = 155;
                drawX2 = 500;
                


            }
            double distance2 = Math.Pow(drawX3 - drawX, 2) + Math.Pow(drawY3 - drawY, 2);
            if (distance2 < 40)
            {
                playButton1.Visible = true;
                quitButton1.Visible = true;
                playButton1.Text = "Play Again?";
                gametimer.Enabled = false;
                speed = 1;
                drawY = 155;
                drawX3 = 600;
                
                

            }
            double distance3 = Math.Pow(drawX4 - drawX, 2) + Math.Pow(drawY4 - drawY, 2);
            if (distance3 < 40)
            {
                playButton1.Visible = true;
                quitButton1.Visible = true;
                playButton1.Text = "Play Again?";
                gametimer.Enabled = false;
                speed = 1;
                drawY = 155;
                drawX4 = 800;
            }
            double distance4 = Math.Pow(drawX5 - drawX, 2) + Math.Pow(drawY5 - drawY, 2);
            if (distance4 < 40)
            {
                playButton1.Visible = true;
                quitButton1.Visible = true;
                playButton1.Text = "Play Again?";
                gametimer.Enabled = false;
                speed = 1;
                drawY = 155;
                drawX5 = 600;

            }
            double distance5 = Math.Pow(drawX6 - drawX, 2) + Math.Pow(drawY6 - drawY, 2);
            if (distance5 < 40)
            {
                playButton1.Visible = true;
                quitButton1.Visible = true;
                playButton1.Text = "Play Again?";
                gametimer.Enabled = false;
                speed = 1;
                drawY = 155;
                drawX6 = 500;

            }
            double distance6 = Math.Pow(drawX7 - drawX, 2) + Math.Pow(drawY7 - drawY, 2);
            if (distance6 < 40)
            {
                playButton1.Visible = true;
                quitButton1.Visible = true;
                playButton1.Text = "Play Again?";
                gametimer.Enabled = false;
                speed = 1;
                drawY = 155;
                drawX7 = 700;

            }
            //increase speed (maybe)

            // - add one to global counter
            // - if counter equal 0
            //    - speed +=2;
            //    - counter = 0;
            if (counter <= 60)
            {
                counter++;
                //speed += 1;
            }

            if (speed >= 15)
            {
                speed = 1;
            }
            if (speed2 >= 15)
            {
                speed2 = 1;
            }
            if (speed3 >= 15)
            {
                speed3 = 1;
            }
            if (speed4 >= 15)
            {
                speed4 = 1;
            }
            if (speed5 >= 15)
            {
                speed5 = 1;
            }
            if (speed6 >= 15)
            {
                speed6 = 1;
            }
            Refresh();
        }
        
        

    
        public void bulletdodger_paint(object sender, PaintEventArgs e)
        {

            e.Graphics.FillEllipse(drawbrush, drawX, drawY, 40, 30);
            e.Graphics.FillRectangle(drawbrush2, drawX2, drawY2, 50, 40);
            e.Graphics.FillRectangle(drawbrush2, drawX3, drawY3, 50, 40);
            e.Graphics.FillRectangle(drawbrush2, drawX4, drawY4, 50, 40);
            e.Graphics.FillRectangle(drawbrush2, drawX5, drawY5, 50, 40);
            e.Graphics.FillRectangle(drawbrush2, drawX6, drawY6, 50, 40);
            e.Graphics.FillRectangle(drawbrush2, drawX7, drawY7, 50, 40);
        }



    }
}
