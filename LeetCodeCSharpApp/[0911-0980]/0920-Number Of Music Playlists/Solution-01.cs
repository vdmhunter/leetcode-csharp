namespace LeetCodeCSharpApp.NumberOfMusicPlaylists01;

public class Solution
{
    private const long Mod = 1_000_000_007L;

    public int NumMusicPlaylists(int n, int goal, int k)
    {
        var dp = new long[goal + 1, n + 1];
        dp[0, 0] = 1;

        for (var i = 1; i <= goal; i++)
        {
            for (var j = 1; j <= n; j++)
            {
                dp[i, j] = dp[i - 1, j - 1] * (n - j + 1) % Mod;
                dp[i, j] = (dp[i, j] + dp[i - 1, j] * Math.Max(j - k, 0) % Mod) % Mod;
            }
        }

        return (int)dp[goal, n];
    }
}
