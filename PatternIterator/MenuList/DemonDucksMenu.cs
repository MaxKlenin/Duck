using System;
using PatternIterator.Iterator;
using PatternIterator.Menu;

namespace PatternIterator.MenuList
{
    public class DemonDucksMenu : IMenu
    {
        private const int MaxItems = 6;
        private int _numberOfItems;
        private readonly MenuItem[] _menuItems;

        public DemonDucksMenu()
        {
            _menuItems = new MenuItem[MaxItems];
            AddItem("Ultimate HOT Wings", "Wings straight from the 9th lvl of hell", false, 6.66);
            AddItem("Ultimate HOT Things", "Hot as hell fire", false, 6.66);
            AddItem("Cup of milk", "this cup kinda help you :)", true, 0.666);
        }

        private void AddItem(string name, string description, bool vegetarian, double price)
        {
            var menuItem = new MenuItem(name, description, vegetarian, price);
            try
            {
                _menuItems[_numberOfItems] = menuItem;
                _numberOfItems += 1;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
            }
        }

        public IIterator<MenuItem> CreateIterator()
        {
            return new DemonDucksMenuIterator(_menuItems);
        }
    }
}