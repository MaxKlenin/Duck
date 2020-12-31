using System;
using PatternStrategy.Behaviors.Interface;

namespace PatternStrategy.Behaviors.Name
{
    internal class WoodName : IName
    {
        public void Name()
        {
            Console.WriteLine("Wood Duck");
        }
    }
}