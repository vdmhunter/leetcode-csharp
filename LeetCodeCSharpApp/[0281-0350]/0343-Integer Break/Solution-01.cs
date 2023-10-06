// ReSharper disable PossibleLossOfFraction

namespace LeetCodeCSharpApp.IntegerBreak01;

public class Solution
{
    public int IntegerBreak(int n)
    {
        return n <= 3
            ? n - 1
            : n % 3 != 0
                ? n % 3 == 1 ? (int)Math.Pow(3, n / 3 - 1) * 4 : (int)Math.Pow(3, n / 3) * 2
                : (int)Math.Pow(3, n / 3);
    }
}
