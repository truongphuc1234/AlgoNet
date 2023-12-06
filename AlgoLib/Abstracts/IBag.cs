namespace AlgoLib.Abstracts;

public interface IBag<T> : ICollection<T>
{
    void Add(T item);

}