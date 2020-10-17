using System;
using PatternStrategy.Behaviors.Interface;

namespace PatternStrategy.Behaviors.Quack
{
    internal class CantQuack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("I can't Quack");
        }
    }
}
