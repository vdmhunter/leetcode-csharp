namespace LeetCodeCSharpApp.MaximumNumberOfJumpsToReachTheLastIndex01;

public class Solution
{
    public int MaximumJumps(int[] nums, int target)
    {
        var n = nums.Length;
        var dp = new int[n];

        Array.Fill(dp, -1);

        dp[0] = 0;

        for (var i = 0; i < n; i++)
        {
            if (dp[i] == -1)
                continue;

            for (var j = i + 1; j < n; j++)
            {
                if (Math.Abs(nums[j] - nums[i]) > target)
                    continue;

                if (dp[j] == -1)
                    dp[j] = dp[i] + 1;
                else
                    dp[j] = Math.Max(dp[j], dp[i] + 1);
            }
        }

        return dp[n - 1];
    }
}
