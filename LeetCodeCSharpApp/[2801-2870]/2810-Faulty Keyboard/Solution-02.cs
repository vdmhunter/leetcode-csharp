using System.Text;

namespace LeetCodeCSharpApp.FaultyKeyboard02;

public class Solution
{
    public string FinalString(string s)
    {
        var sb = new StringBuilder();
        var flag = true;

        foreach (var ch in s)
        {
            if (ch == 'i')
            {
                flag = !flag;

                continue;
            }

            if (flag)
                sb.Append(ch);
            else
                sb.Insert(0, ch);
        }

        if (flag)
            return sb.ToString();

        return flag
            ? sb.ToString()
            : new string(sb.ToString().Reverse().ToArray());
    }
}
