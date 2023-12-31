namespace LeetCodeCSharpApp.LargestSubstringBetweenTwoEqualCharacters02;

public class Solution
{
    public int MaxLengthBetweenEqualCharacters(string s)
    {
        return s.Select((c, i) => new { c, i })
            .GroupBy(x => x.c)
            .Where(g => g.Count() > 1)
            .Select(g => g.Last().i - g.First().i - 1)
            .DefaultIfEmpty(-1)
            .Max();
    }
}
