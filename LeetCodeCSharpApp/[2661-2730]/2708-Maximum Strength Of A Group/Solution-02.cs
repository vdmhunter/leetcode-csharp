namespace LeetCodeCSharpApp.MaximumStrengthOfAGroup02;

public class Solution
{
    public long MaxStrength(int[] nums)
    {
        var result = 1L;
        var size = nums.Length;
        var count = 0;

        nums = nums.OrderBy(n => n).ToArray();

        for (var i = 0; i < size; ++i)
            if (result * nums[i] > 0 || i + 1 < size && nums[i + 1] < 0)
            {
                result *= nums[i];
                ++count;
            }

        return count > 0 ? result : nums[size - 1];
    }
}
