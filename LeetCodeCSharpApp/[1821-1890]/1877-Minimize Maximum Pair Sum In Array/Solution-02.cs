namespace LeetCodeCSharpApp.MinimizeMaximumPairSumInArray02;

public class Solution
{
    public int MinPairSum(int[] nums)
    {
        var result = 0;
        var n = nums.Length;

        Array.Sort(nums);

        for (var i = 0; i < n / 2; i++)
            result = Math.Max(result, nums[i] + nums[n - 1 - i]);

        return result;
    }
}
