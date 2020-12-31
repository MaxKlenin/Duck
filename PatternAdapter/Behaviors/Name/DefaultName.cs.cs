using System;
using PatternAdapter.Behaviors.Interface;

namespace PatternAdapter.Behaviors.Name
{
    internal class DefaultName : IName
    {
        public void Name()
        {
            Console.WriteLine("Default Turkey");
        }
    }
}