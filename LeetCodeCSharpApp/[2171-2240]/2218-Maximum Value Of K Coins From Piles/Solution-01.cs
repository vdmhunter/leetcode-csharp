namespace LeetCodeCSharpApp.MaximumValueOfKCoinsFromPiles01;

public class Solution
{
    public int MaxValueOfCoins(IList<IList<int>> piles, int k)
    {
        var memo = new int[piles.Count + 1][];

        for (var i = 0; i < memo.Length; i++)
        {
            memo[i] = new int[k + 1];
            Array.Fill(memo[i], -1);
        }

        return Dp(piles, memo, 0, k);
    }

    private static int Dp(IList<IList<int>> piles, int[][] memo, int i, int k)
    {
        if (k == 0 || i == piles.Count)
            return 0;

        if (memo[i][k] != -1)
            return memo[i][k];

        var res = Dp(piles, memo, i + 1, k);
        var cur = 0;

        for (var j = 0; j < Math.Min(piles[i].Count, k); ++j)
        {
            cur += piles[i][j];
            res = Math.Max(res, cur + Dp(piles, memo, i + 1, k - j - 1));
        }

        memo[i][k] = res;

        return res;
    }
}
