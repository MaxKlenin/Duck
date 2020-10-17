using System;
using PatternStrategy.Behaviors.Interface;

namespace PatternStrategy.Behaviors.Swim
{
    internal class CantSwim : ISwim
    {
        public void Swim()
        {
            Console.WriteLine("I can't swim");
        }
    }
}
