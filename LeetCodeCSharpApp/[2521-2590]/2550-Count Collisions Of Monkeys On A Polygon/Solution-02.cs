using System.Numerics;

namespace LeetCodeCSharpApp.CountCollisionsOfMonkeysOnAPolygon02;

public class Solution
{
    private const int M = 1000000007;

    public int MonkeyMove(int n)
    {
        return (int)((BigInteger.ModPow(2, n, M) - 2 + M) % M);
    }
}
