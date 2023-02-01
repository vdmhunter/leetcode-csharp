// ReSharper disable IdentifierTypo

namespace LeetCodeCSharpApp.NthTribonacciNumber01;

public class Solution
{
    public int Tribonacci(int n)
    {
        var t = new[] { 0, 1, 1 };

        for (var i = 3; i <= n; ++i)
            t[i % 3] = t[0] + t[1] + t[2];

        return t[n % 3];
    }
}
