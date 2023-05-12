namespace LeetCodeCSharpApp.SolvingQuestionsWithBrainpower01;

public class Solution
{
    public long MostPoints(int[][] questions)
    {
        var n = questions.Length;
        var dp = new long[n + 1];

        for (var i = n - 1; i >= 0; i--)
        {
            var nextIndex = i + questions[i][1] + 1;
            var nextValue = nextIndex < n ? dp[nextIndex] : 0;
            dp[i] = Math.Max(dp[i + 1], nextValue + questions[i][0]);
        }

        return dp[0];
    }
}
