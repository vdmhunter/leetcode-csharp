namespace LeetCodeCSharpApp.MaximumDeletionsOnAString01;

public class Solution
{
    public int DeleteString(string s)
    {
        var n = s.Length;
        var lcs = new int[n + 1][]; //new int[n + 1][n + 1];
        var dp = new int[n];
        
        for (var i = n - 1; i >= 0; --i)
        {
            lcs[i] = new int[n + 1];
            dp[i] = 1;
            
            for (var j = i + 1; j < n; ++j)
            {
                if (s[i] == s[j])
                    lcs[i][j] = lcs[i + 1][j + 1] + 1;
                
                if (lcs[i][j] >= j - i)
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
            }
        }

        return dp[0];
    }
}
