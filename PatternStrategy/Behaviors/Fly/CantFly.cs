using System;
using PatternStrategy.Behaviors.Interface;

namespace PatternStrategy.Behaviors.Fly
{
    internal class CantFly : IFly
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly!");
        }
    }
}
