namespace LeetCodeCSharpApp.MinimumNumberOfOperationsToMakeAllArrayElementsEqualTo1_02;

public class Solution
{
    public int MinOperations(int[] nums)
    {
        var g = nums[0];
        var len = nums.Length;

        for (var i = 1; i < len; i++)
            g = Gcd(g, nums[i]);

        if (g != 1)
            return -1;

        if (nums.Contains(1))
            return len - nums.Count(n => n == 1);

        var result = len - 1;

        while (true)
        {
            result++;
            nums = Enumerable.Range(0, nums.Length - 1)
                .Select(i => Gcd(nums[i], nums[i + 1]))
                .ToArray();

            if (nums.Contains(1))
                return result;
        }
    }

    private static int Gcd(int a, int b)
    {
        return b == 0 ? a : Gcd(b, a % b);
    }
}
