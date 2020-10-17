using PatternDecorator.Decorator;
using PatternDecorator.Meat;

namespace PatternDecorator.Topping
{
    public class GrillVegetables : AdditiveToMeat
    {
        public GrillVegetables(MeatBase meats)
            : base(meats.Name + ",+ Grill Vegetables", meats)
        {
        }

        protected override decimal GetPrice()
        {
            return 5;
        }
    }
}