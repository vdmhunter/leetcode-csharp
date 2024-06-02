namespace LeetCodeCSharpApp.ScoreOfAString01;

public class Solution
{
    public int ScoreOfString(string s)
    {
        var result = 0;

        for (var i = 0; i < s.Length - 1; i++)
            result += Math.Abs(s[i] - s[i + 1]);

        return result;
    }
}
