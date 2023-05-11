namespace LeetCodeCSharpApp.UncrossedLines01;

public class Solution
{
    public int MaxUncrossedLines(int[] nums1, int[] nums2)
    {
        int m = nums1.Length, n = nums2.Length;

        if (m < n)
            return MaxUncrossedLines(nums2, nums1);

        var dp = new int[n + 1];

        for (var i = 0; i < m; i++)
            for (int j = 0, prev = 0; j < n; j++)
            {
                var cur = dp[j + 1];

                if (nums1[i] == nums2[j])
                    dp[j + 1] = 1 + prev;
                else
                    dp[j + 1] = Math.Max(dp[j + 1], dp[j]);

                prev = cur;
            }

        return dp[n];
    }
}
