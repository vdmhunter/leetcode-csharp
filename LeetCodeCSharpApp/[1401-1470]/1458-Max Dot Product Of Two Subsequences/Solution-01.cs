namespace LeetCodeCSharpApp.MaxDotProductOfTwoSubsequences01;

public class Solution
{
    public int MaxDotProduct(int[] nums1, int[] nums2)
    {
        int n = nums1.Length, m = nums2.Length;
        var dp = new int[n, m];

        for (var i = 0; i < n; ++i)
        {
            for (var j = 0; j < m; ++j)
            {
                dp[i, j] = CalculateDotProduct(nums1, nums2, i, j);
                dp[i, j] = UpdateDotProduct(dp, i, j);
            }
        }

        return dp[n - 1, m - 1];
    }

    private static int CalculateDotProduct(int[] nums1, int[] nums2, int i, int j)
    {
        return nums1[i] * nums2[j];
    }

    private static int UpdateDotProduct(int[,] dp, int i, int j)
    {
        if (i > 0 && j > 0)
            dp[i, j] += Math.Max(dp[i - 1, j - 1], 0);

        if (i > 0)
            dp[i, j] = Math.Max(dp[i, j], dp[i - 1, j]);

        if (j > 0)
            dp[i, j] = Math.Max(dp[i, j], dp[i, j - 1]);

        return dp[i,j];
    }
}
