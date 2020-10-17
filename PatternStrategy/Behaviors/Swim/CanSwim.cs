using System;
using PatternStrategy.Behaviors.Interface;

namespace PatternStrategy.Behaviors.Swim
{
    internal class CanSwim : ISwim
    {
        public void Swim()
        {
            Console.WriteLine("I can swim");
        }
    }
}
