namespace LeetCodeCSharpApp.MinimumInsertionStepsToMakeAStringPalindrome01;

public class Solution
{
    public int MinInsertions(string s)
    {
        var n = s.Length;
        var dp = new int[n + 1];

        for (var i = 0; i < n; ++i)
        {
            var prev = 0;

            for (var j = 0; j < n; ++j)
            {
                var temp = dp[j + 1];

                dp[j + 1] = s[i] == s[n - 1 - j]
                    ? prev + 1
                    : Math.Max(dp[j], dp[j + 1]);

                prev = temp;
            }
        }

        return n - dp[n];
    }
}
