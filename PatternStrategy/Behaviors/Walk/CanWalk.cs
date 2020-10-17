using System;
using PatternStrategy.Behaviors.Interface;

namespace PatternStrategy.Behaviors.Walk
{
    internal class CanWalk : IWalk
    {
        public void Walk()
        {
            Console.WriteLine("I can walk");
        }
    }
    
}
