namespace LeetCodeCSharpApp.DeleteOperationForTwoStrings01;

public class Solution
{
    public int MinDistance(string word1, string word2)
    {
        var dp = new int[word1.Length + 1][];
        for (var i = 0; i <= word1.Length; i++)
        {
            dp[i] = new int[word2.Length + 1];
            for (var j = 0; j <= word2.Length; j++)
                if (i == 0 || j == 0)
                    dp[i][j] = 0;
                else
                    dp[i][j] = word1[i - 1] == word2[j - 1]
                        ? dp[i - 1][j - 1] + 1
                        : Math.Max(dp[i - 1][j], dp[i][j - 1]);
        }
            
        
        var val = dp[word1.Length][word2.Length];
        
        return word1.Length - val + word2.Length - val;
    }
}
