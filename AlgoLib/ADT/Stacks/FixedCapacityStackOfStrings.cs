using AlgoLib.Abstracts;

namespace AlgoLib.ADT.Stacks;

public class FixedCapacityStackOfStrings(int cap) : IStack<string>
{
    private readonly string[] a = new string[cap];
    private int n;

    public bool IsEmpty() => n == 0;

    public string Pop()
    {
        n--;
        return a[n + 1];
    }

    public void Push(string item)
    {
        n++;
        a[n] = item;
    }

    public int Size() => n;
    
    //1.3.1
    public bool IsFull()
    {
        return n == a.Length;
    }
}