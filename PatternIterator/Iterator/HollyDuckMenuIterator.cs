using System.Collections.Generic;

namespace PatternIterator.Iterator
{
    internal class HollyDuckMenuIterator : IIterator<MenuItem>
    {
        private readonly List<MenuItem> _items;
        private int _position;

        public HollyDuckMenuIterator(List<MenuItem> items)
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
            if (_position >= _items.Count || _items[_position] == null)
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