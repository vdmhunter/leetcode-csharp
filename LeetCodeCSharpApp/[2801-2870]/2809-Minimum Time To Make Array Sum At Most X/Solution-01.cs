namespace LeetCodeCSharpApp.MinimumTimeToMakeArraySumAtMostX01;

public class Solution
{
    public int MinimumTime(IList<int> nums1, IList<int> nums2, int x)
    {
        var n = nums1.Count;

        var p = Enumerable.Range(0, n)
            .Select(i => (n1: nums1[i], n2: nums2[i]))
            .OrderBy(t => t.n2)
            .ToList();

        var dp = new int[n + 1];

        foreach (var (n1, n2) in p)
            for (var i = n - 1; i >= 0; i--)
                dp[i + 1] = Math.Max(dp[i + 1], dp[i] + (i + 1) * n2 + n1);

        var s1 = nums1.Sum();
        var s2 = nums2.Sum();

        for (var i = 0; i <= n; i++)
            if (s2 * i + s1 - dp[i] <= x)
                return i;

        return -1;
    }
}
