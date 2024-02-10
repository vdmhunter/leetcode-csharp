namespace LeetCodeCSharpApp.PalindromicSubstrings01;

public class Solution
{
    public int CountSubstrings(string s)
    {
        var n = s.Length;
        var result = 0;
        var dp = new bool[n, n];

        for (var i = n - 1; i >= 0; i--)
        {
            for (var j = i; j < n; j++)
            {
                dp[i, j] = s[i] == s[j] && (j - i + 1 < 3 || dp[i + 1, j - 1]);

                if (dp[i, j])
                    result++;
            }
        }

        return result;
    }
}
