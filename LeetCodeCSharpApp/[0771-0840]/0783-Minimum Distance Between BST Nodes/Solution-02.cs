namespace LeetCodeCSharpApp.MinimumDistanceBetweenBSTNodes02;

public class Solution
{
    public int MinimizeSum(int[] nums)
    {
        var n = nums.Length;
        Array.Sort(nums);

        return new[] { nums[n - 1] - nums[0], nums[n - 1] - nums[2], nums[n - 3] - nums[0], nums[n - 2] - nums[1] }
            .Min();
    }
}
