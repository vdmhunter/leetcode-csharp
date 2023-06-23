// ReSharper disable IdentifierTypo

namespace LeetCodeCSharpApp.LongestArithmeticSubsequence01;

public class Solution
{
    public int LongestArithSeqLength(int[] nums)
    {
        int result = 2, n = nums.Length;
        var dp = new Dictionary<int, int>[n];

        for (var j = 0; j < nums.Length; j++)
        {
            dp[j] = new Dictionary<int, int>();

            for (var i = 0; i < j; i++)
            {
                var d = nums[j] - nums[i];

                if (dp[i].TryGetValue(d, out var value))
                    dp[j][d] = value + 1;
                else
                    dp[j][d] = 2;

                result = Math.Max(result, dp[j][d]);
            }
        }

        return result;
    }
}
