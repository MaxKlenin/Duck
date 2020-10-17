﻿using System;
using PatternAdapter.Behaviors.Interface;

namespace PatternAdapter.Behaviors.Swim
{
    internal class CanSwim : ISwim
    {
        public void Swim() 
        {
            Console.WriteLine("I can swim!");
        }
    }
}
