namespace LeetCodeCSharpApp.QueryKthSmallestTrimmedNumber02;

public class Solution
{
    public int[] SmallestTrimmedNumbers(string[] nums, int[][] queries)
    {
        return queries
            .Aggregate(Enumerable.Empty<int>(), (ans, query) => ans.Append(nums
                .Select((s, index) => (s, index))
                .OrderBy(p => (p.s[^query[1]..], p.index))
                .ElementAt(query[0] - 1).index), ans => ans.ToArray());
    }
}
