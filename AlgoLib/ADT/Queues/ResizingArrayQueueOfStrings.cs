using System.Collections;
using AlgoLib.Abstracts;

namespace AlgoLib.ADT.Queues;

public class ResizingArrayQueue<T> : IQueue<T>, IEnumerable<T>
{

    private T[] a = new T[10];
    private int n;

    public T Dequeue()
    {
        var item = a[0];
        for (int i = 0; i < n - 1; i++)
        {
            a[i] = a[i + 1];
        }
        a[n] = default;
        n--;
        if (n > 0 && n == a.Length / 4)
        {
            Resize(a.Length / 2);
        }
        return item;
    }

    public void Enqueue(T item)
    {
        if (n == a.Length)
        {
            Resize(2 * a.Length);
        }
        n++;
        a[n] = item;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i > n; i++)
        {
            yield return a[i];
        }
    }

    public bool IsEmpty() => n == 0;

    public int Size() => n;

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
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