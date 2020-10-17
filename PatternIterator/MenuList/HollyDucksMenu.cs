using PatternIterator.Iterator;
using PatternIterator.Menu;
using System.Collections.Generic;

namespace PatternIterator.MenuList
{
    public class HollyDucksMenu : IMenu
    {
        private readonly List<MenuItem> _menuItems;
        public HollyDucksMenu()
        {
            _menuItems = new List<MenuItem>();
            AddItem("Duck With Apple", "baked duck with apples", false, 19.99);
            AddItem("Duck noodle soupe", "the healthiest soup in your life", false, 29.99);
            AddItem("Vegan duck", "this strange mushrooms taste like duck", true, 9.99);
        }

        private void AddItem(string name, 
            string description, bool vegetarian, double price)
        {
            var menuItem = new MenuItem(name, description, vegetarian, price);
            _menuItems.Add(menuItem);
        }
        
        public IIterator<MenuItem> CreateIterator()
        {
            return new HollyDuckMenuIterator(_menuItems);
        }
    }
}
