namespace LeetCodeCSharpApp.RunningSumOf1DArray01;

public class Solution
{
    public int[] RunningSum(int[] nums)
    {
        var result = (int[])nums.Clone();

        for (var i = 0; i < nums.Length; i++)
            result[i] = nums[..i].Sum();

        return result;
    }
}
