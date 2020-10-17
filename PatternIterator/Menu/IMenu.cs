using PatternIterator.Iterator;

namespace PatternIterator.Menu
{
    public interface IMenu
    {
        IIterator<MenuItem> CreateIterator();
    }
}