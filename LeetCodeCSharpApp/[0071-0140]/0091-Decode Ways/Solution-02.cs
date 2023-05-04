namespace LeetCodeCSharpApp.DecodeWays02;

public class Solution
{
    public int NumDecodings(string s)
    {
        int dp1 = 1, dp2 = 0, n = s.Length;

        for (var i = n - 1; i >= 0; i--)
        {
            var dp = s[i] == '0' ? 0 : dp1;

            if (i < n - 1 && (s[i] == '1' || s[i] == '2' && s[i + 1] < '7'))
                dp += dp2;

            dp2 = dp1;
            dp1 = dp;
        }

        return dp1;
    }
}
