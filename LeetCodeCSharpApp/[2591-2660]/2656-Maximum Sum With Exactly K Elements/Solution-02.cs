namespace LeetCodeCSharpApp.MaximumSumWithExactlyKElements02;

public class Solution
{
    public int MaximizeSum(int[] nums, int k)
    {
        var m = nums.Max();

        return ((m + k) * (m + k - 1) - m * (m - 1)) / 2;
    }
}
