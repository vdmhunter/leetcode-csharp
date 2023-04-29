namespace LeetCodeCSharpApp.CountNumberOfDistinctIntegersAfterReverseOperations01;

public class Solution
{
    public int CountDistinctIntegers(int[] nums)
    {
        var list = nums.ToList();
        list.AddRange(nums.Select(Reverse));

        return list.Distinct().Count();
    }

    private static int Reverse(int n)
    {
        var result = 0;

        while (n > 0)
        {
            var remainder = n % 10;
            result = result * 10 + remainder;
            n /= 10;
        }

        return result;
    }
}
