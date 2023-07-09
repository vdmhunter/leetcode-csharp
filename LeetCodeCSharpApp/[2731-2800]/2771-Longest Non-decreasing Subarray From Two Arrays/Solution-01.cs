namespace LeetCodeCSharpApp.LongestNonDecreasingSubarrayFromTwoArrays01;

public class Solution
{
    public int MaxNonDecreasingLength(int[] nums1, int[] nums2)
    {
        var n = nums1.Length;
        var dp = new int[n, 2];
        dp[0, 0] = 1;
        dp[0, 1] = 1;

        var result = 1;

        for (var i = 1; i < n; i++)
        {
            dp[i, 0] = dp[i, 1] = 1;

            if (nums1[i] >= nums1[i - 1])
                dp[i, 0] = Math.Max(dp[i, 0], dp[i - 1, 0] + 1);

            if (nums1[i] >= nums2[i - 1])
                dp[i, 0] = Math.Max(dp[i, 0], dp[i - 1, 1] + 1);

            if (nums2[i] >= nums1[i - 1])
                dp[i, 1] = Math.Max(dp[i, 1], dp[i - 1, 0] + 1);

            if (nums2[i] >= nums2[i - 1])
                dp[i, 1] = Math.Max(dp[i, 1], dp[i - 1, 1] + 1);

            result = Math.Max(result, Math.Max(dp[i, 0], dp[i, 1]));
        }

        return result;
    }
}
