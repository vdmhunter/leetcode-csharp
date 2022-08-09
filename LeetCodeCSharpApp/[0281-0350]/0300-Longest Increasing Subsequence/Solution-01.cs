namespace LeetCodeCSharpApp.LongestIncreasingSubsequence01;

/// <summary>
/// Dynamic Programming
/// </summary>
public class Solution
{
    public int LengthOfLIS(int[] nums)
    {
        var n = nums.Length;
        var dp = Enumerable.Repeat(1, n).ToList();
        
        for (var i = 0; i < n; ++i)
            for (var j = 0; j < i; ++j)
                if (nums[i] > nums[j] && dp[i] < dp[j] + 1)
                    dp[i] = dp[j] + 1;

        return dp.Max();
    }
}
