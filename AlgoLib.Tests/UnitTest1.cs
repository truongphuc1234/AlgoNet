using AlgoLib.ADT.Stacks;
using ClientCode.StackClient;

namespace AlgoLib.Tests;

public class StackTests
{
    [Fact]
    public void Test_Output_String_1_3_2()
    {
        var stack = new LinkedListStack<string>();
        var text = "it was - the best - of times - - - it was - the - -";
        var popString = "";
        foreach (string str in text.Split(" "))
        {
            if (!str.Contains('-'))
            {
                stack.Push(str);
            }
            else
            {
                popString += " " + stack.Pop();
            }
        }
        Assert.Equal(1, stack.Size);
        Assert.Equal(" was best times of the was the it", popString);
    }

    [Fact]
    public void Test_Parentheses_1_3_4()
    {
        var text = "[()]{}{[()()]()}";
        Assert.True(StackClient.CheckParentheses(text));
    }

    [Fact]
    public void Test_Parentheses_1_3_4_2()
    {
        var text = "[(])";
        Assert.False(StackClient.CheckParentheses(text));
    }

    // [Fact]
    // public void Test_Parentheses_1_3_4_2()
    // {
    //     var stack = new LinkedListStack<char>();
    //     var text = "[(])";
    //     var map = new Dictionary<char, char> { { '[', ']' }, { ']', '[' }, { '(', ')' }, { ')', '(' }, { '{', '}' }, { '}', '{' }, };


    //     foreach (char str in text)
    //     {
    //         if (map[str] == stack.Peek())
    //         {
    //             stack.Pop();
    //         }
    //         else
    //         {
    //             stack.Push(str);
    //         }
    //     }
    //     Assert.Equal(4, stack.Size);
    // }
}