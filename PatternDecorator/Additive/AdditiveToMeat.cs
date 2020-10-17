using PatternDecorator.Meat;

namespace PatternDecorator.Decorator
{
    public abstract class AdditiveToMeat : MeatBase
    {
        protected AdditiveToMeat(string n, MeatBase meats) : base(n, meats)
        {
        }
    }
}