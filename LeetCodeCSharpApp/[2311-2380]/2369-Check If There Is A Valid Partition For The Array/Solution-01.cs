namespace LeetCodeCSharpApp.CheckIfThereIsAValidPartitionForTheArray01;

public class Solution
{
    public bool ValidPartition(int[] nums)
    {
        var n = nums.Length;
        int[] dp = { 0, 0, 0, 1 };

        for (var i = 0; i < n; i++)
        {
            dp[i % 4] = 0;

            if (i - 1 >= 0 && nums[i] == nums[i - 1])
                dp[i % 4] |= dp[(i + 2) % 4];

            if (i - 2 >= 0 && nums[i] == nums[i - 1] && nums[i - 1] == nums[i - 2])
                dp[i % 4] |= dp[(i + 1) % 4];

            if (i - 2 >= 0 && nums[i] - 1 == nums[i - 1] && nums[i - 1] == nums[i - 2] + 1)
                dp[i % 4] |= dp[(i + 1) % 4];
        }

        return dp[(n - 1) % 4] > 0;
    }
}
