using System;
using PatternStrategy.Behaviors.Interface;

namespace PatternStrategy.Behaviors.Name
{
    internal class RobotName : IName
    {
        public void Name()
        {
            Console.WriteLine("Robot Duck");
        }
    }
}