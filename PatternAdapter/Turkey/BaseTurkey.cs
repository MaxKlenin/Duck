﻿using PatternAdapter.Behaviors.Interface;

namespace PatternAdapter.Turkey
{
    public abstract class BaseTurkey
    {
        private readonly IFly _fly;
        private readonly IGobble _gobble;
        private readonly ISwim _swim;
        private readonly IWalk _walk;

        protected BaseTurkey(IFly fly, IGobble gobble, ISwim swim, IWalk walk)
        {
            _fly = fly;
            _gobble = gobble;
            _swim = swim;
            _walk = walk;
        }

        public void MakeFly()
        {
            _fly.Fly();
        }

        public void MakeGobble()
        {
            _gobble.Gobble();
        }

        public void MakeSwim()
        {
            _swim.Swim();
        }

        public void MakeWalk()
        {
            _walk.Walk();
        }

        public void ShowInfo()
        {
            _fly.Fly();
            _gobble.Gobble();
            _swim.Swim();
            _walk.Walk();
        }
    }
}
