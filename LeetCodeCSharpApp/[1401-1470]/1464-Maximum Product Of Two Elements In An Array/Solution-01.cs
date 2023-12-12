namespace LeetCodeCSharpApp.MaximumProductOfTwoElementsInAnArray01;

public class Solution
{
    public int MaxProduct(int[] nums)
    {
        var sortedNums = nums.OrderByDescending(n => n).Take(2).ToArray();

        return (sortedNums[0] - 1) * (sortedNums[1] - 1);
    }
}
