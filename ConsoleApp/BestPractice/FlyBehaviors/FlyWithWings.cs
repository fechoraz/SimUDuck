﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.BestPractice.FlyBehaviors
{
    public class FlyWithWings
        : IFlyBehavior
    {
        public void MakeFly()
        {
            Console.WriteLine("I'm flying!!");
        }
    }
}
