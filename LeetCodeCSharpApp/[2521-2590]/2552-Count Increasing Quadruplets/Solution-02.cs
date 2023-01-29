namespace LeetCodeCSharpApp.CountIncreasingQuadruplets02;

public class Solution
{
    public long CountQuadruplets(int[] nums)
    {
        var n = nums.Length;
        var dp = new long[n];
        var result = 0L;

        for (var j = 0; j < n; j++)
        {
            var prevSmall = 0;

            for (var i = 0; i < j; i++)
            {
                if (nums[j] > nums[i])
                {
                    prevSmall++;
                    result += dp[i];
                }
                else if (nums[j] < nums[i])
                    dp[i] += prevSmall;
            }
        }

        return result;
    }
}
