using PatternStrategy.DuckType;
using System.Collections.Generic;
using System;

namespace PatternSingleton
{
    public sealed class Singleton
    {
        private static Singleton _instance;
        private static Dictionary<BaseDuck, int> ducksDict = new Dictionary<BaseDuck, int>(3);

        private Singleton()
        {
        }

        public static Singleton getInstance()
        {
            if (_instance == null)
                _instance = new Singleton();
            return _instance;
        }

        public void PackDuck(BaseDuck baseDuck, int count)
        {   
            Console.Write($"On factory was packed:{count} - ");
            baseDuck.ShowName();
            try
            {
                ducksDict.Add(baseDuck, count);
            }
            catch (ArgumentException)
            {
                ducksDict[baseDuck] += count;
            }
        }
    }
}
