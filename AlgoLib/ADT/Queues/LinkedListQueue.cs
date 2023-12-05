using System.Collections;
using AlgoLib.Abstracts;
using AlgoLib.ADT.LinkedList;

namespace AlgoLib.ADT.Queues;

public class LinkedListQueue<T> : IQueue<T>, IEnumerable<T>
{
    private Node<T>? first;
    private Node<T>? last;
    private int n;

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node<T>? current = first;
        while (current != null)
        {
            yield return current.Item;
            current = current.Next;
        }
    }

    public void Enqueue(T item)
    {
        Node<T> oldLast = last;
        last = new Node<T>
        {
            Item = item,
            Next = null
        };
        if (IsEmpty())
        {
            first = last;
        }
        else
        {
            oldLast.Next = last;
        }
        n++;
    }

    public T Dequeue()
    {
        T item = first.Item;
        first = first.Next;
        if (IsEmpty())
        {
            last = null;
        }
        n--;
        return item;
    }

    public bool IsEmpty() => n == 0;

    public int Size() => n;
}