using System.Numerics;

namespace LeetCodeCSharpApp.CheckIfPointIsReachable01;

public class Solution
{
    public bool IsReachable(int targetX, int targetY)
    {
        var v = (int)BigInteger.GreatestCommonDivisor(targetX, targetY);

        while (v % 2 == 0)
            v /= 2;

        return v == 1;
    }
}
