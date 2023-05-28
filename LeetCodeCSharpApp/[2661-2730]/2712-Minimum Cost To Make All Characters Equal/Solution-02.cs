namespace LeetCodeCSharpApp.MinimumCostToMakeAllCharactersEqual02;

public class Solution
{
    public long MinimumCost(string s)
    {
        var result = 0L;

        for (var i = 1; i < s.Length; i++)
            result += s[i - 1] == s[i] ? 0 : Math.Min(i, s.Length - i);

        return result;
    }
}
