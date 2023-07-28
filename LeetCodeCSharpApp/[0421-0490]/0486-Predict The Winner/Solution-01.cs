namespace LeetCodeCSharpApp.PredictTheWinner01;

public class Solution
{
    public bool PredictTheWinner(int[] nums)
    {
        if (nums == null)
            return true;

        var n = nums.Length;

        if ((n & 1) == 0)
            return true;

        var dp = new int[n];

        for (var i = n - 1; i >= 0; i--)
            for (var j = i; j < n; j++)
                if (i == j)
                    dp[i] = nums[i];
                else
                    dp[j] = Math.Max(nums[i] - dp[j], nums[j] - dp[j - 1]);

        return dp[n - 1] >= 0;
    }
}
