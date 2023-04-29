namespace LeetCodeCSharpApp.MinimumDifficultyOfAJobSchedule01;

public class Solution
{
    public int MinDifficulty(int[] jobDifficulty, int d)
    {
        var dp = new int[d + 1, jobDifficulty.Length + 1];

        for (var i = 0; i <= d; i++)
            for (var j = 0; j < jobDifficulty.Length; j++)
                dp[i, j] = int.MaxValue;

        for (var days = 1; days <= d; days++)
            for (var i = 0; i < jobDifficulty.Length - days + 1; i++)
                UpdateDP(i, days);

        return dp[d, 0] < int.MaxValue ? dp[d, 0] : -1;

        #region UpdateDP

        void UpdateDP(int i, int days)
        {
            var difficult = 0;

            for (var j = i + 1; j < jobDifficulty.Length - days + 2; j++)
            {
                difficult = Math.Max(difficult, jobDifficulty[j - 1]);

                if (dp[days - 1, j] == int.MaxValue)
                    continue;

                var current = difficult + dp[days - 1, j];
                dp[days, i] = Math.Min(dp[days, i], current);
            }
        }

        #endregion
    }
}
