namespace LeetCodeCSharpApp.MinimumMovesToEqualArrayElementsII02;

public class Solution
{
    public int MinMoves2(int[] nums)
    {
        Array.Sort(nums);

        var median = nums[nums.Length / 2];

        return nums.Sum(n => Math.Abs(median - n));
    }
}
