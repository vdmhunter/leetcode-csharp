namespace LeetCodeCSharpApp.WordBreak01;

public class Solution
{
    public bool WordBreak(string s, IList<string> wordDict)
    {
        var dp = new bool[s.Length + 1];
        dp[0] = true;

        var set = new HashSet<string>(wordDict);

        for (var i = 0; i < dp.Length; i++)
        {
            for (var j = 0; j < i; j++)
            {
                if (dp[j] && set.Contains(s[j..i]))
                {
                    dp[i] = true;

                    break;
                }
            }
        }

        return dp[s.Length];
    }
}
