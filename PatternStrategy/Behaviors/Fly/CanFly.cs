using System;
using PatternStrategy.Behaviors.Interface;

namespace PatternStrategy.Behaviors.Fly
{
    internal class CanFly : IFly
    {
        public void Fly()
        {
            Console.WriteLine("I can fly!");
        }
    }
}