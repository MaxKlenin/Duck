using System;
using PatternStrategy.Behaviors.Interface;

namespace PatternStrategy.Behaviors.Fly
{
    internal class FlyWithRocketPower : IFly
    {
        public void Fly()
        {
            Console.WriteLine("I HAVE A JetPack!");
        }
    }
}
