using System.Numerics;

namespace LeetCodeCSharpApp.UniquePaths02;

public class Solution
{
    public int UniquePaths(int m, int n)
    {
        BigInteger Factorial(int x) => x > 1 ? x * Factorial(x - 1) : 1;

        return (int)(Factorial(m + n - 2) / Factorial(m - 1) / Factorial(n - 1));
    }
}
