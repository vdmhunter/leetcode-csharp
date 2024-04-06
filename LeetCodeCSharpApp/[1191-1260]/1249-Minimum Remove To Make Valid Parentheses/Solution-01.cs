using System.Text;

namespace LeetCodeCSharpApp.MinimumRemoveToMakeValidParentheses01;

public class Solution
{
    public string MinRemoveToMakeValid(string s)
    {
        var sb = new StringBuilder(s);
        var st = new Stack<int>();

        for (var i = 0; i < sb.Length; ++i)
        {
            if (sb[i] == '(')
                st.Push(i);

            if (sb[i] != ')')
                continue;

            if (st.Count > 0)
                st.Pop();
            else
                sb[i] = '*';
        }

        while (st.Count > 0)
            sb[st.Pop()] = '*';

        return sb.ToString().Replace("*", "");
    }
}
