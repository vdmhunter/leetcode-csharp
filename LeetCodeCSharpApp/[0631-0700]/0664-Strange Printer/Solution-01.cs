namespace LeetCodeCSharpApp.StrangePrinter01;

public class Solution
{
    public int StrangePrinter(string s)
    {
        var n = s.Length;
        var dp = new int[n, n];

        for (var i = n - 1; i >= 0; i--)
        {
            dp[i, i] = 1;

            for (var j = i + 1; j < n; j++)
            {
                dp[i, j] = dp[i, j - 1] + 1;

                for (var k = i; k < j; k++)
                    if (s[k] == s[j])
                        dp[i, j] = Math.Min(dp[i, j], dp[i, k] + (k + 1 <= j - 1 ? dp[k + 1, j - 1] : 0));
            }
        }

        return dp[0, n - 1];
    }
}
