using System;
using PatternStrategy.Behaviors.Interface;

namespace PatternStrategy.Behaviors.Walk
{
    internal class CantWalk : IWalk
    {
        public void Walk()
        {
            Console.WriteLine("I can't walk");
        }
    }
}
