using PatternStrategy.Behaviors.Interface;

namespace PatternStrategy.DuckType
{
    public abstract class BaseDuck
    {
        private readonly IFly _fly;
        private readonly IQuack _quack;
        private readonly ISwim _swim;
        private readonly IWalk _walk;
        private readonly IName _name;

        protected BaseDuck()
        {
        }

        protected BaseDuck(IFly fly, IQuack quack, ISwim swim, IWalk walk, IName name)
        {
            _fly = fly;
            _quack = quack;
            _swim = swim;
            _walk = walk;
            _name = name;
        }

        public virtual void MakeFly()
        {
            _fly.Fly();
        }

        public virtual void MakeQuack()
        {
            _quack.Quack();
        }

        public virtual void MakeSwim()
        {
            _swim.Swim();
        }

        public virtual void MakeWalk()
        {
            _walk.Walk();
        }

        public virtual void ShowName()
        {
            _name.Name();
        }

        public virtual void ShowInfo()
        {
            _fly.Fly();
            _quack.Quack();
            _swim.Swim();
            _walk.Walk();
            _name.Name();
        }
    }
}