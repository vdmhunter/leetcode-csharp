namespace LeetCodeCSharpApp.BestTeamWithNoConflicts01;

public class Solution
{
    public int BestTeamScore(int[] scores, int[] ages)        
    {
        var n = scores.Length;
        var players = new (int Age, int Score)[n];
        
        for (var i = 0; i < n; ++i)
            players[i] = (ages[i], scores[i]);
        
        Array.Sort(players, (a, b) => a.Age == b.Age ? a.Score - b.Score : a.Age - b.Age);
        
        var dp = new int[n];
        var result = 0;
        
        for (var i = 0; i < n; ++i)
        {
            dp[i] = players[i].Score;
            
            for (var j = 0; j < i; ++j)
                if (players[j].Score <= players[i].Score)
                    dp[i] = Math.Max(dp[i], dp[j] + players[i].Score);
            
            result = Math.Max(result, dp[i]);
        }

        return result;
    }
}
