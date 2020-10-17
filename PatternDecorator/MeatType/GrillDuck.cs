using PatternDecorator.Meat;

namespace PatternDecorator.MeatType
{
    public class GrillDuck : MeatBase
    {
        public GrillDuck()
            : base("Курочка на гриле")
        {
        }

        protected override decimal GetPrice()
        {
            return 50;
        }
    }
}