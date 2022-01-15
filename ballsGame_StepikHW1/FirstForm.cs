﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ballsGame_StepikHW1
{
    public partial class FirstForm : Form
    {
        Random random;
        List<RandomBall> balls = new List<RandomBall>();
        int count = 0;
        
        public FirstForm()
        {
            InitializeComponent();
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            random = new Random();
            var randomBallsNumber = random.Next(5,11);

            for (int i = 0; i < randomBallsNumber; i++)
            {
                var ball = new RandomBall(this);
                balls.Add(ball);
                ball.Start();
            }

            button_Stop.Enabled = true;
                      
         }

     

        private void button_Stop_Click(object sender, EventArgs e)
        {
            CountBalls();

        }

        private void CountBalls()
        {
            foreach (var ball in balls)
            {
                ball.Stop();

                if (ball.isOnForm())
                {
                    count++;
                }
            }

            MessageBox.Show($"Поймано {count} шариков");
            count = 0;
        }

        private void FirstForm_Load(object sender, EventArgs e)
        {
            button_Stop.Enabled = false;
        }
    }

    
}
