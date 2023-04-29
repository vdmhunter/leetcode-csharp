namespace LeetCodeCSharpApp.NumberOfWaysToReachAPositionAfterExactlyKSteps02;

public class Solution
{
    private const int Mode = 1_000_000_007;

    public int NumberOfWays(int startPos, int endPos, int k)
    {
        if ((startPos - endPos - k) % 2 != 0)
            return 0;

        if (Math.Abs(startPos - endPos) > k)
            return 0;

        var result = 1L;

        for (var i = 0; i < (endPos - startPos + k) / 2; ++i)
        {
            result = result * (k - i) % Mode;
            result = result * Inv(i + 1) % Mode;
        }

        return (int)result;
    }

    private static long Inv(long a)
    {
        if (a == 1)
            return 1;

        return (Mode - Mode / a) * Inv(Mode % a) % Mode;
    }
}
