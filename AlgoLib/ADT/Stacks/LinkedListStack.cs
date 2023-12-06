using System.Collections;
using AlgoLib.Abstracts;
using AlgoLib.ADT.LinkedList;

namespace AlgoLib.ADT.Stacks;

public class LinkedListStack<T> : IStack<T>, IEnumerable<T>
{
    private Node<T> first;
    private int n;

    public bool IsEmpty() => n == 0;

    public T Pop()
    {
        T item = first.Item;
        first = first.Next;
        n--;
        return item;
    }

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

    public int Size => n;

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node<T> current = first;
        while (current != null)
        {
            yield return current.Item;
            current = current.Next;
        }
    }

    public T? Peek()
    {
        return IsEmpty() ? default : first.Item;
    }
}