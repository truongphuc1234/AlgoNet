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
        return stack.Size() == 0;
    }

    public static string FillInfixExpression(string text)
    {
        var ops = new LinkedListStack<string>();
        var vals = new LinkedListStack<string>();
        {
            foreach (string ch in text.Split(" "))
            {
                if (ch == "+" || ch == "-" || ch == "*" || ch == "/")
                {
                    ops.Push(ch);
                }
                else if (ch == ")")
                {
                    var op = ops.Pop();
                    var val = vals.Pop();
                    val = "( " + vals.Pop() + " " + op + " " + val + " )";
                    vals.Push(val);
                }
                else
                {
                    vals.Push(ch);
                }
            }
            return vals.Pop();
        }
    }

    public static int EvaluateString(string text)
    {
        var ops = new LinkedListStack<char>();
        var vals = new LinkedListStack<int>();
        foreach (char ch in text)
        {
            if (ch != ' ')
            {
                if (ch == '(')
                {
                    continue;
                }
                if (ch == '+' || ch == '-' || ch == '*' || ch == '/')
                {
                    ops.Push(ch);
                    continue;
                }
                else if (ch == ')')
                {
                    var op = ops.Pop();
                    var v = vals.Pop();

                    if (op == '+')
                    {
                        v = vals.Pop() + v;
                    }

                    if (op == '-')
                    {
                        v = vals.Pop() - v;
                    }

                    if (op == '*')
                    {
                        v = vals.Pop() * v;
                    }

                    if (op == '/')
                    {
                        v = vals.Pop() / v;
                    }
                    vals.Push(v);
                }
                else
                {
                    if (int.TryParse(ch.ToString(), out int v))
                    {
                        vals.Push(v);
                    }
                }
            }
        }
        return vals.Pop();
    }
}