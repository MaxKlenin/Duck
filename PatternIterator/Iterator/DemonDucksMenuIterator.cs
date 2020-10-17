namespace PatternIterator.Iterator
{
    internal class DemonDucksMenuIterator : IIterator<MenuItem>
    {
        private readonly MenuItem[] _items;
        private int _position;

        public DemonDucksMenuIterator(MenuItem[] items)
        {
            _items = items;
        }

        public MenuItem NextTo()
        {
            _position++;
            return (_items[_position - 1]);
        }

        public bool HasNext()
        {
            if (_position >= _items.Length || _items[_position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}