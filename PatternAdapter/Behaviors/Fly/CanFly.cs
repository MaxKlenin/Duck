﻿using System;
using PatternAdapter.Behaviors.Interface;

namespace PatternAdapter.Behaviors.Fly
{
    internal class CanFly : IFly
    {
        public void Fly()
        {
            Console.WriteLine("I can fly slowly!");
        }
    }
}
