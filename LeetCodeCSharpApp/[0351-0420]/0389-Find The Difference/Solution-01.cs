namespace LeetCodeCSharpApp.FindTheDifference01;

public class Solution
{
    public char FindTheDifference(string s, string t)
    {
        var c = (char)0;

        foreach (var cs in s.ToCharArray())
            c ^= cs;

        foreach (var ct in t.ToCharArray())
            c ^= ct;

        return c;
    }
}
