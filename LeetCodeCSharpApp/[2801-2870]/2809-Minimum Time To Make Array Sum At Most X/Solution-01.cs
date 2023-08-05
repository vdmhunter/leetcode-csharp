namespace LeetCodeCSharpApp.MinimumTimeToMakeArraySumAtMostX01;

public class Solution
{
    public int MinimumTime(IList<int> nums1, IList<int> nums2, int x)
    {
        var n = nums1.Count;

        var p = Enumerable.Range(0, n)
            .Select(i => (nums2[i], nums1[i]))
            .OrderBy(t => t.Item1)
            .ToList();

        var dp = new int[n + 1];

        foreach (var (a, b) in p)
            for (var i = n - 1; i >= 0; i--)
                dp[i + 1] = Math.Max(dp[i + 1], dp[i] + (i + 1) * a + b);

        var n1Sum = nums1.Sum();
        var n2Sum = nums2.Sum();

        for (var i = 0; i <= n; i++)
            if (n2Sum * i + n1Sum - dp[i] <= x)
                return i;

        return -1;
    }
}
