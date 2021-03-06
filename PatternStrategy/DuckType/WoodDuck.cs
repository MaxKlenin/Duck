﻿using PatternStrategy.Behaviors.Fly;
using PatternStrategy.Behaviors.Quack;
using PatternStrategy.Behaviors.Swim;
using PatternStrategy.Behaviors.Walk;
using PatternStrategy.Behaviors.Name;

namespace PatternStrategy.DuckType
{
    public class WoodDuck : BaseDuck
    {
        public WoodDuck() : base(new CantFly(), new CantQuack(), new CanSwim(), new CantWalk(), new WoodName())
        {
        }
    }
}