namespace LeetCodeCSharpApp.ValidParentheses01;

public class Solution
{
    public bool IsValid(string s)
    {
        var k = new Stack<char>();

        foreach (var c in s)
        {
            switch (c)
            {
                case '(':
                    k.Push(')');
                    continue;
                case '{':
                    k.Push('}');
                    continue;
                case '[':
                    k.Push(']');
                    continue;
            }

            if (k.Count == 0 || c != k.Pop())
                return false;
        }

        return k.Count == 0;
    }
}
