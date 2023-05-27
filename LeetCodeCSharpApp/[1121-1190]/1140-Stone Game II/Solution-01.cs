namespace LeetCodeCSharpApp.StoneGameII01;

public class Solution
{
    public int StoneGameII(int[] piles)
    {
        if (piles.Length == 0)
            return 0;

        var dp = new int[piles.Length, piles.Length];

        var suffixSum = new int[piles.Length];
        suffixSum[^1] = piles[^1];

        for (var i = piles.Length - 2; i >= 0; --i)
            suffixSum[i] = piles[i] + suffixSum[i + 1];

        return Helper(piles, dp, suffixSum, 0, 1);
    }

    private static int Helper(int[] piles, int[,] dp, int[] suffixSum, int i, int M)
    {
        if (i == piles.Length)
            return 0;

        if (i + 2 * M >= piles.Length)
            return suffixSum[i];

        if (dp[i, M] != 0)
            return dp[i, M];

        var result = 0;

        for (var x = 1; x <= 2 * M; ++x)
            result = Math.Max(result, suffixSum[i] - Helper(piles, dp, suffixSum, i + x, Math.Max(M, x)));

        dp[i, M] = result;

        return result;
    }
}
