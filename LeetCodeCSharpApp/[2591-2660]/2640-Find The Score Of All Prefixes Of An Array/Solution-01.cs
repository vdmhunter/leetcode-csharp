namespace LeetCodeCSharpApp.FindTheScoreOfAllPrefixesOfAnArray01;

public class Solution
{
    public long[] FindPrefixScore(int[] nums)
    {
        var n = nums.Length;
        var result = new long[n];
        var max = nums[0];

        result[0] = nums[0] * 2;

        for (var i = 1; i < n; i++)
        {
            max = Math.Max(max, nums[i]);
            result[i] = result[i - 1] + nums[i] + max;
        }

        return result;
    }
}
