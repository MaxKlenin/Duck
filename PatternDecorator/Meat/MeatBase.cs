namespace PatternDecorator.Meat
{
    public abstract class MeatBase
    {
        private readonly MeatBase _measts;

        protected MeatBase(string name, MeatBase meats)
        {
            _measts = meats;
            Name = name;
        }

        protected MeatBase(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public decimal Price()
        {
            return GetPrice() + (_measts?.Price() ?? 0);
        }

        protected abstract decimal GetPrice();
    }
}