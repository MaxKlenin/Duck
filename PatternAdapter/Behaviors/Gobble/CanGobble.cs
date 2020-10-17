﻿using System;
using PatternAdapter.Behaviors.Interface;

namespace PatternAdapter.Behaviors.Gobble
{
    internal class CanGobble : IGobble
    {
        public void Gobble() 
        {
            Console.WriteLine("Gobble gobble Gobble gobble");
        }

    }
}
