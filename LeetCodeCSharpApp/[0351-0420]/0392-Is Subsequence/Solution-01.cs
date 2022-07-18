namespace LeetCodeCSharpApp.IsSubsequence01;

public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        int sp = 0, tp = 0;
        
        while (sp < s.Length && tp < t.Length)
            if (s[sp] == t[tp])
            {
                sp++;
                tp++;
            }
            else
                tp++;

        return sp == s.Length;
    }
}
