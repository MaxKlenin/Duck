using PatternDecorator.Decorator;
using PatternDecorator.Meat;

namespace PatternDecorator.Topping
{
    public class ExtraCheese : AdditiveToMeat
    {
        public ExtraCheese(MeatBase m)
            : base(m.Name + ",+ Extra cheese", m)
        {
        }

        protected override decimal GetPrice()
        {
            return 15;
        }
    }
}