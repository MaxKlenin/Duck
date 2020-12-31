using PatternStrategy.Behaviors.Fly;
using PatternStrategy.Behaviors.Quack;
using PatternStrategy.Behaviors.Swim;
using PatternStrategy.Behaviors.Walk;
using PatternStrategy.Behaviors.Name;

namespace PatternStrategy.DuckType
{
    public class JetPackDuck : BaseDuck
    {
        public JetPackDuck() : base(new FlyWithRocketPower(), new CanQuack(), new CantSwim(), new CanWalk(), new RobotName())
        {
        }
    }

}
