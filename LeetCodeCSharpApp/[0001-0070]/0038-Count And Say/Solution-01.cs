using System.Text;

namespace LeetCodeCSharpApp.CountAndSay01;

public class Solution
{
    public string CountAndSay(int n)
    {
        var s = "1";
        
        for (var i = 1; i < n; i++)
            s = CountIdx(s);
        
        return s;
    }

    private static string CountIdx(string s)
    {
        var sb = new StringBuilder();
        var c = s[0];
        var count = 1;
        
        for (var i = 1; i < s.Length; i++)
            if (s[i] == c)
                count++;
            else
            {
                sb.Append(count);
                sb.Append(c);
                c = s[i];
                count = 1;
            }

        sb.Append(count);
        sb.Append(c);
        
        return sb.ToString();
    }
}
