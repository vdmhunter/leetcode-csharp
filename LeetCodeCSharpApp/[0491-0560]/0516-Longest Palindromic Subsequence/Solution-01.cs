// ReSharper disable IdentifierTypo

namespace LeetCodeCSharpApp.LongestPalindromicSubsequence01;

public class Solution
{
    public int LongestPalindromeSubseq(string s)
    {
        var chars = s.ToCharArray();
        var dp = new int[chars.Length];

        for (var i = 0; i < chars.Length; i++)
        {
            dp[i] = 1;
            var topRight = 0;

            for (var j = i - 1; j >= 0; j--)
            {
                var temp = dp[j];

                if (chars[j] == chars[i])
                    dp[j] = topRight + 2;
                else
                    dp[j] = Math.Max(dp[j], dp[j + 1]);

                topRight = temp;
            }
        }

        return dp[0];
    }
}
