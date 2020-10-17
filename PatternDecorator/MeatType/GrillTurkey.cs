using PatternDecorator.Meat;

namespace PatternDecorator.MeatType
{
    public class GrillTurkey : MeatBase
    {
        public GrillTurkey()
            : base("Индюшатина на гриле")
        {
        }

        protected override decimal GetPrice()
        {
            return 30;
        }
    }
}