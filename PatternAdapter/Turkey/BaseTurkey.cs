﻿using PatternAdapter.Behaviors.Interface;

namespace PatternAdapter.Turkey
{
    public abstract class BaseTurkey
    {
        private IFly _fly;
        private IGobble _gobble;
        private ISwim _swim;
        private IWalk _walk;
        protected BaseTurkey(IFly fly, IGobble gobble, ISwim swim, IWalk walk)
        {
            this._fly = fly;
            this._gobble = gobble;
            this._swim = swim;
            this._walk = walk;
        }

        public virtual void MakeFly()
        {
            _fly.Fly();
        }
        public virtual void MakeGobble()
        {
            _gobble.Gobble();
        }
        public virtual void MakeSwim()
        {
            _swim.Swim();
        }
        public virtual void MakeWalk()
        {
            _walk.Walk();
        }
        public virtual void ShowInfo()
        {
            _fly.Fly();
            _gobble.Gobble();
            _swim.Swim();
            _walk.Walk();
        }
    }
}
