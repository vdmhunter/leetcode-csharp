namespace LeetCodeCSharpApp.MinimizeMaximumPairSumInArray01;

public class Solution
{
    public int MinPairSum(int[] nums)
    {
        var n = nums.Length;

        Array.Sort(nums);

        return nums.Take(n / 2).Zip(nums.Reverse().Take(n / 2), (a, b) => a + b).Max();
    }
}
