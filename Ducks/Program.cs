using System;
using PatternAdapter.Turkey;
using PatternAdapter.TurkeyAdapter;
using PatternIterator.MenuList;
using PatternIterator.Personnel;
using PatternStrategy.DuckType;
using PatternDecorator.Meat;
using PatternDecorator.MeatType;
using PatternDecorator.Topping;

namespace Ducks
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("**** Wood Duck ****");
            var woodDuck = new WoodDuck();
            woodDuck.ShowInfo();
           
            Console.WriteLine("**** Jet Pack Duck ****");
            var robotDuck = new JetPackDuck();
            robotDuck.ShowInfo();
           
            Console.WriteLine("**** Default Duck ****");
            var defaultDuck = new DefaultDuck();
            defaultDuck.ShowInfo();
           
            Console.WriteLine("**** Turkey Before adapter ****");
            var turkey = new DefaultTurkey();
            turkey.ShowInfo();
            turkey.MakeGobble();
            Console.WriteLine("**** Turkey After adapter ****");
            var turkeyAdapted = new TurkeyAdapter(turkey);
            turkeyAdapted.ShowInfo();
            turkeyAdapted.MakeQuack();
           
            var demonDuckmenu = new DemonDucksMenu();
            var hollyDucksMenu = new HollyDucksMenu();
            var waitress = new Waitress(demonDuckmenu,hollyDucksMenu);
            waitress.PrintMenu();

            MeatBase grillDuck = new GrillDuck();
            grillDuck = new ExtraCheese(grillDuck);
            grillDuck = new GrillVegetables(grillDuck);
            Console.WriteLine($"Name:{grillDuck.Name}\n Count:{grillDuck.Price()}");
            MeatBase grillTurkey = new GrillTurkey();
            grillTurkey = new ExtraCheese(grillTurkey);          
            Console.WriteLine($"Name:{grillTurkey.Name}\n Count:{grillTurkey.Price()}");


        }
    }
}
        