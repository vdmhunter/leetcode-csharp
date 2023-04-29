namespace LeetCodeCSharpApp.MaximizeWinFromTwoSegments;

public class Solution
{
    public int MaximizeWin(int[] prizePositions, int k)
    {
        int result = 0, n = prizePositions.Length, j = 0;
        var dp = new int[n + 1];

        for (var i = 0; i < n; ++i)
        {
            while (prizePositions[j] < prizePositions[i] - k)
                ++j;

            dp[i + 1] = Math.Max(dp[i], i - j + 1);
            result = Math.Max(result, i - j + 1 + dp[j]);
        }

        return result;
    }
}
