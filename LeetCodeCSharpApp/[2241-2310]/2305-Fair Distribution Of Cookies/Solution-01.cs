namespace LeetCodeCSharpApp.FairDistributionOfCookies01;

public class Solution
{
    public int DistributeCookies(int[] cookies, int k)
    {
        var n = cookies.Length;
        var sums = new int[1 << n];

        for (var mask = 0; mask < 1 << n; mask++)
            for (var i = 0; i < n; i++)
                sums[mask] += (mask & 1 << i) != 0 ? cookies[i] : 0;

        var dp = new int[1 << n];
        Array.Fill(dp, int.MaxValue);
        dp[0] = 0;

        for (var child = 1; child <= k; child++)
        {
            var tmp = (int[])dp.Clone();

            for (var mask = 0; mask < 1 << n; mask++)
                for (var subMask = mask; subMask != 0; subMask = subMask - 1 & mask)
                    tmp[mask] = Math.Min(tmp[mask], Math.Max(sums[subMask], dp[subMask ^ mask]));

            dp = tmp;
        }

        return dp[^1];
    }
}
