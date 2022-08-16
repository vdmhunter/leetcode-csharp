namespace LeetCodeCSharpApp.FirstUniqueCharacterInAString01;

public class Solution
{
    public int FirstUniqChar(string s)
    {
        var first = s
            .GroupBy(c => c)
            .Select((g, i) => new { c = g.Key, cnt = g.Count(), i })
            .OrderBy(g => g.cnt)
            .ThenBy(g => g.i)
            .First();

        return first.cnt == 1 ? s.ToList().IndexOf(first.c) : -1;
    }
}
