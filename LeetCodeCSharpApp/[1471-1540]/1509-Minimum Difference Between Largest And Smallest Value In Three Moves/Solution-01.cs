namespace LeetCodeCSharpApp.MinimumDifferenceBetweenLargestAndSmallestValueInThreeMoves01;

public class Solution
{
    public int MinDifference(int[] nums)
    {
        if (nums.Length <= 4)
            return 0;

        Array.Sort(nums);

        int result = nums[^1] - nums[0];

        for (var i = 0; i <= 3; i++)
            result = Math.Min(result, nums[nums.Length - (3 - i) - 1] - nums[i]);

        return result;
    }
}
