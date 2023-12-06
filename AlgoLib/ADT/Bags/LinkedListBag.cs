using System.Collections;
using AlgoLib.Abstracts;
using AlgoLib.ADT.LinkedList;

namespace AlgoLib.ADT.Bags;

public class LinkedListBag<T> : IBag<T>, IEnumerable<T>
{

    private Node<T>? first;
    private int n;

    public void Add(T item)
    {
        var oldFirst = first;
        first = new()
        {
            Item = item,
            Next = oldFirst
        };
        n++;
    }

    public bool IsEmpty() => n == 0;

    public int Size() => n;

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
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
}