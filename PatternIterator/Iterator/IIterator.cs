namespace PatternIterator.Iterator
{
    public interface IIterator<T>
    {
        bool HasNext();
        T NextTo();
    }
}