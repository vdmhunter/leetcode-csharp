using System.Numerics;

namespace LeetCodeCSharpApp.NumberOfWaysToReorderArrayToGetSameBST01;

public class Solution
{
    private const int Mod = 1_000_000_007;

    public int NumOfWays(int[] nums)
    {
        return (int)((Solve(nums) - 1) % Mod);
    }

    private static BigInteger Solve(int[] nums)
    {
        if (nums.Length <= 2)
            return 1;

        var left = nums.Where(item => item < nums[0]).ToArray();
        var right = nums.Where(item => item > nums[0]).ToArray();

        return C(left.Length + right.Length, right.Length) * Solve(left) * Solve(right);
    }

    private static BigInteger C(int a, int b)
    {
        return Factorial(a) / Factorial(b) / Factorial(a - b);
    }

    private static BigInteger Factorial(int value)
    {
        BigInteger result = 1;

        for (var x = 2; x <= value; ++x)
            result *= x;

        return result;
    }
}
