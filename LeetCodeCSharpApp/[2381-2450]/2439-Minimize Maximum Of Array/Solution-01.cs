namespace LeetCodeCSharpApp.MinimizeMaximumOfArray01;

public class Solution
{
    public int MinimizeArrayValue(int[] nums)
    {
        long sum = 0L, result = 0L;

        for (var i = 0; i < nums.Length; ++i)
        {
            sum += nums[i];
            result = Math.Max(result, (sum + i) / (i + 1));
        }

        return (int)result;
    }
}
