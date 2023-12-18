namespace LeetCodeCSharpApp.MaximumProductDifferenceBetweenTwoPairs02;

public class Solution
{
    public int MaxProductDifference(int[] nums)
    {
        Array.Sort(nums);
        var n = nums.Length;

        return nums[n - 1] * nums[n - 2] - nums[0] * nums[1];
    }
}
