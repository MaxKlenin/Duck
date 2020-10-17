using System;
using PatternIterator.Iterator;
using PatternIterator.Menu;

namespace PatternIterator.Personnel
{
    public class Waitress
    {
        private readonly IMenu _demonDucksMenu;
        private readonly IMenu _hollyDucksMenu;

        public Waitress(IMenu demonDucksMenu, IMenu hollyDucksMenu)
        {
            _demonDucksMenu = demonDucksMenu;
            _hollyDucksMenu = hollyDucksMenu;
        }

        public void PrintMenu()
        {
            var demonDucksIterator = _demonDucksMenu.CreateIterator();
            var hollyDucksIterator = _hollyDucksMenu.CreateIterator();
            Console.WriteLine("MENU\n----\n Demon Duck");
            PrintMenu(demonDucksIterator);
            Console.WriteLine("MENU\n----\n Holly Duck");
            PrintMenu(hollyDucksIterator);
        }

        private static void PrintMenu(IIterator<MenuItem> iterator)
        {
            while (iterator.HasNext())
            {
                var menuItem = iterator.NextTo();
                Console.WriteLine("===============================");
                Console.Write(menuItem.GetName() + " - (");
                Console.WriteLine(menuItem.GetPrice() + "$)");
                Console.WriteLine(menuItem.GetDescription());
            }
        }
    }
}