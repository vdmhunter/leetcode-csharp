namespace LeetCodeCSharpApp.KnightDialer01;

public class Solution
{
    private const int Mod = 1_000_000_007;

    private static readonly int[][] Moves =
    {
        new[] { 4, 6 }, new[] { 6, 8 }, new[] { 7, 9 },
        new[] { 4, 8 }, new[] { 3, 9, 0 }, new int[] { },
        new[] { 1, 7, 0 }, new[] { 2, 6 }, new[] { 1, 3 },
        new[] { 2, 4 }
    };

    public int KnightDialer(int n)
    {
        var dp = new int[2][];
        dp[0] = new int[10];
        dp[1] = new int[10];

        for (var i = 0; i < 10; i++)
            dp[0][i] = 1;

        for (var hops = 0; hops < n - 1; hops++)
        {
            for (var j = 0; j < 10; j++)
            {
                dp[~hops & 1][j] = 0;
            }

            for (var node = 0; node < 10; node++)
            {
                foreach (var nei in Moves[node])
                {
                    dp[~hops & 1][nei] += dp[hops & 1][node];
                    dp[~hops & 1][nei] %= Mod;
                }
            }
        }

        var result = dp[~n & 1].Aggregate(0L, (current, x) => current + x);

        return (int)(result % Mod);
    }
}
