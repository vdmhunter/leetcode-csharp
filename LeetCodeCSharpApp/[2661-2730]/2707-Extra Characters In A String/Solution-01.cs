namespace LeetCodeCSharpApp.ExtraCharactersInAString01;

public class Solution
{
    public int MinExtraChar(string s, string[] dictionary)
    {
        var n = s.Length;
        var dp = Enumerable.Repeat(n, n + 1).ToArray();
        dp[0] = 0;

        for (var i = 0; i < n; i++)
        {
            if (dp[i] != n)
                foreach (var word in dictionary.Where(w => i + w.Length <= n && s[i..(i + w.Length)] == w))
                    dp[i + word.Length] = Math.Min(dp[i + word.Length], dp[i]);

            dp[i + 1] = Math.Min(dp[i + 1], dp[i] + 1);
        }

        return dp[n];
    }
}
