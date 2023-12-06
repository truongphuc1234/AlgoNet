using System.Collections;
using AlgoLib.Abstracts;

namespace AlgoLib.ADT.Stacks;

public class ResizingCapacityStack<T> : IStack<T>, IEnumerable<T>
{
    private T[] a = new T[10];
    private int n;



    public bool IsEmpty() => n == 0;

    public T Pop()
    {
        T item = a[n];
        a[n] = default;
        n--;
        if (n > 0 && n == a.Length / 4)
        {
            Resize(a.Length / 2);
        }
        return item;
    }

    public void Push(T item)
    {
        if (n == a.Length)
        {
            Resize(2 * a.Length);
        }
        n++;
        a[n] = item;
    }

    public int Size => n;

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = n - 1; i >= 0; i--)
        {
            yield return a[i];
        }
    }

    private void Resize(int max)
    {
        T[] item = new T[max];
        for (int i = 0; i < n; i++)
        {
            item[i] = a[i];
        }
        a = item;
    }
}