namespace LeetCodeCSharpApp.DifferenceBetweenElementSumAndDigitSumOfAnArray01;

public class Solution
{
    public int DifferenceOfSum(int[] nums)
    {
        return Math.Abs(nums.Sum() - nums.Select(n => n.ToString().ToCharArray().Select(c => c - '0').Sum()).Sum());
    }
}
