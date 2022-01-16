﻿
using System;
using System.Windows.Forms;

namespace ballsCommonWF
{
    public class RandomBall : Ball
    {
        private Random random = new Random();
        
        public RandomBall(Form form) : base(form)
        {
            radius = random.Next(20, 50);
            centerX = random.Next(0, form.Size.Width);
            centerY = random.Next(0, form.Height);
            vX = random.Next(-5, 6);
            vY = random.Next(-5, 6);
 
        }

        public bool isMovable()
        {
            return timer.Enabled;
        }

        
    }
}
