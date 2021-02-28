﻿using System;
using System.Drawing;
using System.Threading;

namespace Snakecode
{
    public class Speed 
    {
        public Speed(int score) 
        {
            if (score <= 10)
            {
                Thread.Sleep(100);
            }
            else if (score >= 11 && score <= 20)
            {
                Thread.Sleep(80);
            }
            else if (score >= 21 && score <= 30)
            {
                Thread.Sleep(60);
            }
            else if (score >= 31 && score <= 40)
            {
                Thread.Sleep(40);
            }
        }
    }
}