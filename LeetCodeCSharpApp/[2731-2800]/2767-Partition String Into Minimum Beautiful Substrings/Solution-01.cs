namespace LeetCodeCSharpApp.PartitionIntoMinimumBeautifulSubstrings01;

public class Solution
{
    public int MinimumBeautifulSubstrings(string s)
    {
        var n = s.Length;
        var pow5InBinary = new string[14];

        for (var i = 0; i < 14; i++)
            pow5InBinary[i] = Convert.ToString((int)Math.Pow(5, i), 2);

        var dp = new int[n + 1];
        Array.Fill(dp, n + 1);
        dp[0] = 0;

        for (var i = 1; i <= n; i++)
        {
            for (var j = i; j >= 1; j--)
            {
                if (s[j - 1] == '0')
                    continue;

                var sub = s[(j - 1)..i];

                if (Array.IndexOf(pow5InBinary, sub) != -1)
                    dp[i] = Math.Min(dp[i], dp[j - 1] + 1);
            }
        }

        return dp[n] == n + 1 ? -1 : dp[n];
    }
}
