﻿using System;
using PatternAdapter.Behaviors.Interface;

namespace PatternAdapter.Behaviors.Walk
{
    internal class CanWalk : IWalk
    {
        public void Walk ()
        {
            Console.WriteLine("I can walk");
        }
    }
}
