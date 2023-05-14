namespace LeetCodeCSharpApp.MaximizeScoreAfterNOperations01;

public class Solution
{
    public int MaxScore(int[] nums)
    {
        var dp = new int[nums.Length / 2 + 1][];

        for (var i = 0; i < dp.Length; i++)
            dp[i] = new int[1 << nums.Length];

        return Dfs(nums, dp, 1, 0);
    }

    private static int Dfs(int[] n, int[][] dp, int i, int mask)
    {
        if (i > n.Length / 2)
            return 0;

        if (dp[i][mask] != 0)
            return dp[i][mask];

        for (var j = 0; j < n.Length; ++j)
            for (var k = j + 1; k < n.Length; ++k)
            {
                var newMask = (1 << j) + (1 << k);

                if ((mask & newMask) == 0)
                    dp[i][mask] = Math.Max(dp[i][mask], i * Gcd(n[j], n[k]) + Dfs(n, dp, i + 1, mask + newMask));
            }

        return dp[i][mask];
    }

    private static int Gcd(int a, int b)
    {
        return b == 0 ? a : Gcd(b, a % b);
    }
}
