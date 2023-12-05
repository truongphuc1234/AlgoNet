namespace AlgoLib.Abstracts;

public interface IStack<T> : ICollection<T>
{
    void Push(T item);
    T Pop();
}