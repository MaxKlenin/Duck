﻿using PatternStrategy.Behaviors.Fly;
using PatternStrategy.Behaviors.Quack;
using PatternStrategy.Behaviors.Swim;
using PatternStrategy.Behaviors.Walk;

namespace PatternStrategy.DuckType
{
    public class DefaultDuck : BaseDuck
    {
        public DefaultDuck() : base(new CanFly(), new CanQuack(), new CanSwim(), new CanWalk())
        {
        }
    }
}