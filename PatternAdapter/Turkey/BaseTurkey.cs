﻿using PatternAdapter.Behaviors.Interface;

namespace PatternAdapter.Turkey
{
    public abstract class BaseTurkey
    {
        private readonly IFly _fly;
        private readonly IGobble _gobble;
        private readonly ISwim _swim;
        private readonly IWalk _walk;
        private readonly IName _name;

        protected BaseTurkey(IFly fly, IGobble gobble, ISwim swim, IWalk walk, IName name)
        {
            _fly = fly;
            _gobble = gobble;
            _swim = swim;
            _walk = walk;
            _name = name;
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

        public virtual void ShowName()
        {
            _name.Name();
        }

        public void ShowInfo()
        {
            _fly.Fly();
            _gobble.Gobble();
            _swim.Swim();
            _walk.Walk();
            _name.Name();
        }
    }
}
