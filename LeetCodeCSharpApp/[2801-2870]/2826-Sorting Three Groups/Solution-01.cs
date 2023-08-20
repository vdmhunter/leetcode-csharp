namespace LeetCodeCSharpApp.SortingThreeGroups01;

public class Solution
{
    public int MinimumOperations(IList<int> nums)
    {
        var n = nums.Count;
        int[] dp = { n, n, n, n };

        foreach (var a in nums)
        {
            dp[a]--;
            dp[2] = Math.Min(dp[2], dp[1]);
            dp[3] = Math.Min(dp[3], dp[2]);
        }

        return dp[3];
    }
}
