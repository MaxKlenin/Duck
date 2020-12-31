using System;
using PatternStrategy.Behaviors.Interface;

namespace PatternStrategy.Behaviors.Name
{
    internal class DefaultName : IName
    {
        public void Name()
        {
            Console.WriteLine("Default Duck");
        }
    }
}