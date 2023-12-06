using AlgoLib.ADT.Stacks;

namespace ClientCode.StackClient;

public class StackClient
{
    public static bool CheckParentheses(string text)
    {
        var stack = new LinkedListStack<char>();
        var map = new Dictionary<char, char> { { ']', '[' }, { ')', '(' }, { '}', '{' }, };


        foreach (char str in text)
        {
            if (map.TryGetValue(str, out char val) && val == stack.Peek())
            {
                stack.Pop();
            }
            else
            {
                stack.Push(str);
            }
        }
        return stack.Size == 0;
    }

       public static string FillInfixExpression(string text)
    {
        var tempStack = new LinkedListStack<char>();
        
        foreach (char ch in text)
        {
            if (ch != ' ' && ) && val == stack.Peek())
            {
                stack.Pop();
            }
            else
            {
                stack.Push(str);
            }
        }
    }
}