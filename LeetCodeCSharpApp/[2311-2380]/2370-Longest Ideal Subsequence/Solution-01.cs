namespace LeetCodeCSharpApp.LongestIdealSubsequence01;

public class Solution
{
    public int LongestIdealString(string s, int k)
    {
        var dp = new int[26];

        foreach (char ch in s)
        {
            int i = ch - 'a';

            int start = Math.Max(0, i - k);
            int end = Math.Min(25, i + k);
            var maxLen = 0;

            for (int j = start; j <= end; j++)
                maxLen = Math.Max(maxLen, dp[j]);

            dp[i] = maxLen + 1;
        }

        var result = 0;

        for (var j = 0; j < 26; j++)
            result = Math.Max(result, dp[j]);

        return result;
    }
}