using AlgoLib.Abstracts;

namespace AlgoLib.ADT.Stacks;

public class FixedCapacityStack<T>(int cap) : IStack<T>
{
    private readonly T[] a = new T[cap];
    private int n;

    public bool IsEmpty() => n == 0;

    public T Pop()
    {
        n--;
        return a[n + 1];
    }

    public void Push(T item)
    {
        n++;
        a[n] = item;
    }

    public int Size => n;
}