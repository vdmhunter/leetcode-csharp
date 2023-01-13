namespace LeetCodeCSharpApp.MaximumProfitInJobScheduling01;

public class Solution
{
    public int JobScheduling(int[] startTime, int[] endTime, int[] profit)
    {
        var comp = Comparer<int>.Create((x, y) => x == y ? 1 : x.CompareTo(y));
        var n = startTime.Length;
        var list = Enumerable.Range(0, n)
            .Select(i => (start: startTime[i], end: endTime[i], profit: profit[i]))
            .OrderBy(x => x.start)
            .ToList();

        for (var i = 0; i < n; i++)
            startTime[i] = list[i].start;

        var dp = new int[n + 1];

        for (var k = n - 1; k >= 0; k--)
        {
            var i = Array.BinarySearch(startTime, k + 1, list.Count - k - 1, list[k].end, comp);
            dp[k] = Math.Max(dp[k + 1], list[k].profit + dp[i < 0 ? ~i : i]);
        }

        return dp[0];
    }
}
