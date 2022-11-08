namespace LeetCodeCSharpApp.MakeTheStringGreat01;

public class Solution
{
    public string MakeGood(string s)
    {
        for (var i = 0; i < s.Length - 1; i++)
            if (Math.Abs(s[i] - s[i + 1]) == 32)
                return MakeGood(string.Concat(s.AsSpan()[..i], s.AsSpan(i + 2)));

        return s;
    }
}
