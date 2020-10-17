using System;
using PatternStrategy.Behaviors.Interface;

namespace PatternStrategy.Behaviors.Quack
{
    internal class CanQuack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("I can Quack");
        }
    }
}