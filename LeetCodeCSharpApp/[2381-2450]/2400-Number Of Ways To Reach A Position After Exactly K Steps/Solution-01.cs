namespace LeetCodeCSharpApp.NumberOfWaysToReachAPositionAfterExactlyKSteps01;

public class Solution
{
    public int NumberOfWays(int startPos, int endPos, int k)
    {
        if (endPos - startPos > k)
            return 0;

        const int mode = 1_000_000_007;
        var dp = new int[2 * k + 1];
        dp[k - 1] = 1;
        dp[k + 1] = 1;

        for (var i = 2; i <= k; i++)
        {
            var dpCopy = dp.ToArray();

            for (var j = 0; j <= 2 * k; j++)
                if (j == 0)
                    dpCopy[0] = dp[1];
                else if (j == 2 * k)
                    dpCopy[2 * k] = dp[2 * k - 1];
                else
                    dpCopy[j] = (dp[j - 1] + dp[j + 1]) % mode;

            dp = dpCopy.ToArray();
        }

        return dp[k + endPos - startPos];
    }
}
