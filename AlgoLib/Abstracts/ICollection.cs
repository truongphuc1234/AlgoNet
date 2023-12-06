namespace AlgoLib.Abstracts;

public interface ICollection<T>
{
    bool IsEmpty();
    int Size { get; }
}