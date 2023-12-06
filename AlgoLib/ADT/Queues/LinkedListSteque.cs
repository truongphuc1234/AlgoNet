using System.Collections;
using AlgoLib.Abstracts;
using AlgoLib.ADT.LinkedList;

namespace AlgoLib.ADT.Queues;

public class LinkedListSteque<T> : ISteque<T>, IEnumerable<T>
{
    private Node<T>? first;
    private Node<T>? last;
    private int n;

    #region Enumerator
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<T> GetEnumerator()
    {
        var current = first;
        while (current != null)
        {
            yield return current.Item;
            current = current.Next;
        }
    }
    #endregion

    public void Enqueue(T item)
    {
        var oldLast = last;
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

    public bool IsEmpty() => first == null && last == null;

    public int Size() => n;

    public void Push(T item)
    {
        Node<T> oldFirst = first;
        first = new Node<T>
        {
            Item = item,
            Next = oldFirst,
        };
        n++;
    }

    public T Pop()
    {
        if (IsEmpty())
        {
            throw new Exception("Stack underflow");
        }
        else
        {
            T item = first.Item;
            first = first.Next;
            n--;
            return item;
        }
    }
}