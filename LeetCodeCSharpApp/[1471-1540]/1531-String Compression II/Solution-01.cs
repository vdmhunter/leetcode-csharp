namespace LeetCodeCSharpApp.StringCompressionII01;

public class Solution
{
    public int GetLengthOfOptimalCompression(string s, int k)
    {
        var n = s.Length;
        var dp = new int[n + 1][];

        for (var i = 0; i < dp.Length; i++)
        {
            dp[i] = new int[k + 1];
            Array.Fill(dp[i], n);
        }

        dp[0][0] = 0;

        for (var x = 1; x <= n; x++)
            for (var y = 0; y <= k; y++)
                UpdateDP(dp, s, y, x);

        return dp[n][k];
    }

    private static void UpdateDP(int[][] dp, string s, int y, int x)
    {
        if (y > 0)
            dp[x][y] = Math.Min(dp[x][y], dp[x - 1][y - 1]);

        int same = 0, diff = 0;

        for (var z = x; z >= 1; z--)
        {
            if (s[z - 1] == s[x - 1])
                same++;
            else
                diff++;

            if (diff > y)
                break;

            dp[x][y] = Math.Min(dp[x][y], dp[z - 1][y - diff] + GetLength(same));
        }
    }

    private static int GetLength(int count)
    {
        return count switch
        {
            1 => 1,
            < 10 => 2,
            < 100 => 3,
            _ => 4
        };
    }
}
