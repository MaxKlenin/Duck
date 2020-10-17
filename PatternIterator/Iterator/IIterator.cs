namespace PatternIterator.Iterator
{
    public interface IIterator<out T>
    {
        bool HasNext();
        T NextTo();
    }
}