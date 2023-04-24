namespace LeetCodeCSharpApp.RestoreTheArray01;

public class Solution
{
    private const int Mod = 1_000_000_007;

    public int NumberOfArrays(string s, int k)
    {
        int sSz = s.Length, dpSz = k.ToString().Length + 1;

        var dp = new int[dpSz];
        dp[sSz % dpSz] = 1;

        for (var i = sSz - 1; i >= 0; --i)
        {
            dp[i % dpSz] = 0;

            if (s[i] == '0')
                continue;

            for (long sz = 1, n = 0; i + sz <= sSz; ++sz)
            {
                n = n * 10 + s[i + (int)sz - 1] - '0';

                if (n > k)
                    break;

                dp[i % dpSz] = (dp[i % dpSz] + dp[(i + sz) % dpSz]) % Mod;
            }
        }

        return dp[0];
    }
}
