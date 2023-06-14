namespace LeetCodeCSharpApp.SummaryRanges02;

public class Solution
{
    public IList<string> SummaryRanges(int[] nums)
    {
        return nums.Select((n, i) => new { n, i })
            .GroupBy(x => x.n - x.i)
            .Select(g => g.Count() > 1 ? g.First().n + "->" + g.Last().n : g.First().n.ToString())
            .ToList();
    }
}
