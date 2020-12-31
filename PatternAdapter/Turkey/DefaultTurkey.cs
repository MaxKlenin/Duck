﻿using PatternAdapter.Behaviors.Fly;
using PatternAdapter.Behaviors.Gobble;
using PatternAdapter.Behaviors.Swim;
using PatternAdapter.Behaviors.Walk;
using PatternAdapter.Behaviors.Name;

namespace PatternAdapter.Turkey
{   
   public class DefaultTurkey : BaseTurkey
   {

        public DefaultTurkey() : base(new CanFly(), new CanGobble(), new CanSwim(), new CanWalk(), new DefaultName())
       {

       }

   }
}
