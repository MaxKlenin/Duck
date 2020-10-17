namespace PatternDecorator.Meat
{
    public abstract class MeatBase
    {
        private readonly MeatBase _meats;

        protected MeatBase(string name, MeatBase meats)
        {
            _meats = meats;
            Name = name;
        }

        protected MeatBase(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public decimal Price()
        {
            return GetPrice() + (_meats?.Price() ?? 0);
        }

        protected abstract decimal GetPrice();
    }
}