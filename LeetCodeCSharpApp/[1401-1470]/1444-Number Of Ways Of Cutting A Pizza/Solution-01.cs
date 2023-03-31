namespace LeetCodeCSharpApp.NumberOfWaysOfCuttingAPizza01;

public class Solution
{
    private const int Mod = 1_000_000_007;

    public int Ways(string[] pizza, int k)
    {
        var dp = new int[pizza.Length, pizza[0].Length, k];
        InitializeDPArray(dp, pizza.Length, pizza[0].Length, k);

        return Calculate(pizza, dp, 0, 0, k - 1);
    }

    private static void InitializeDPArray(int[,,] dp, int m, int n, int cutsRem)
    {
        for (var i = 0; i < m; i++)
            for (var j = 0; j < n; j++)
                for (var k = 0; k < cutsRem; k++)
                    dp[i, j, k] = -1;
    }

    private int Calculate(string[] pizza, int[,,] dp, int sRow, int sCol, int cutsRem)
    {
        if (cutsRem == 0)
            return 1;

        if (dp[sRow, sCol, cutsRem] != -1)
            return dp[sRow, sCol, cutsRem];

        var ways = 0;

        VerticalWays(pizza, dp, sRow, sCol, cutsRem, ref ways);
        HorizontalWays(pizza, dp, sRow, sCol, cutsRem, ref ways);

        dp[sRow, sCol, cutsRem] = ways;

        return dp[sRow, sCol, cutsRem];
    }

    private void HorizontalWays(string[] pizza, int[,,] dp, int sRow, int sCol, int cutsRem, ref int ways)
    {
        var m = pizza.Length;
        var n = pizza[0].Length;

        for (var col = sCol; col < n - 1; col++)
        {
            var leftPresent = ApplePresent(pizza, sRow, m - 1, sCol, col);
            var rightPresent = ApplePresent(pizza, sRow, m - 1, col + 1, n - 1);

            if (!leftPresent || !rightPresent)
                continue;

            var nextWays = Calculate(pizza, dp, sRow, col + 1, cutsRem - 1);
            ways = (ways + nextWays) % Mod;
        }
    }

    private void VerticalWays(string[] pizza, int[,,] dp, int sRow, int sCol, int cutsRem, ref int ways)
    {
        var m = pizza.Length;
        var n = pizza[0].Length;

        for (var row = sRow; row < m - 1; row++)
        {
            var upperPresent = ApplePresent(pizza, sRow, row, sCol, n - 1);
            var lowerPresent = ApplePresent(pizza, row + 1, m - 1, sCol, n - 1);

            if (!upperPresent || !lowerPresent)
                continue;

            var nextWays = Calculate(pizza, dp, row + 1, sCol, cutsRem - 1);
            ways = (ways + nextWays) % Mod;
        }
    }

    private static bool ApplePresent(string[] pizza, int sRow, int eRow, int sCol, int eCol)
    {
        for (var i = sRow; i <= eRow; i++)
            for (var j = sCol; j <= eCol; j++)
                if (pizza[i][j] == 'A')
                    return true;

        return false;
    }
} 