namespace LeetCodeCSharpApp.PrimeInDiagonal01;

public class Solution
{
    public int DiagonalPrime(int[][] nums)
    {
        var p = 0;

        for (var i = 0; i < nums.Length; ++i)
        {
            p = Math.Max(p, IsPrime(nums[i][i]) ? nums[i][i] : 0);
            p = Math.Max(p, IsPrime(nums[i][nums.Length - i - 1]) ? nums[i][nums.Length - i - 1] : 0);
        }

        return p;
    }

    private static bool IsPrime(int n)
    {
        if (n <= 2 || n % 2 == 0)
            return n == 2;

        for (var i = 3; i * i <= n; i += 2)
            if (n % i == 0)
                return false;

        return true;
    }
}
