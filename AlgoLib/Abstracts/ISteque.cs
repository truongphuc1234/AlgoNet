namespace AlgoLib.Abstracts;

public interface ISteque<T> : ICollection<T>
{
    void Push(T item);
    T Pop();
    void Enqueue(T item);
}