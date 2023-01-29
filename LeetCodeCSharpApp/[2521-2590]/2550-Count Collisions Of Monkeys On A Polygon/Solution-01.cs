namespace LeetCodeCSharpApp.CountCollisionsOfMonkeysOnAPolygon01;

public class Solution
{
    private const int M = 1000000007;

    public int MonkeyMove(int n)
    {
        long result = 1L, b = 2L;

        while (n > 0)
        {
            if (n % 2 == 1)
                result = result * b % M;

            b = b * b % M;
            n >>= 1;
        }

        return (int)((result - 2 + M) % M);
    }
}
