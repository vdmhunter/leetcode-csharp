namespace LeetCodeCSharpApp.MinimumDifficultyOfAJobSchedule02;

public class Solution
{
    public int MinDifficulty(int[] jobDifficulty, int d)
    {
        var n = jobDifficulty.Length;

        if (n < d)
            return -1;

        var stack = new Stack<int>();
        var dp1 = new int[n];
        var dp2 = new int[n];

        Array.Fill(dp1, 1_000);

        for (var i = 0; i < d; i++)
        {
            stack.Clear();

            for (var j = i; j < n; j++)
            {
                dp2[j] = j > 0 ? dp1[j - 1] + jobDifficulty[j] : jobDifficulty[j];

                UpdateMinDifficulty(j);

                if (stack.Count > 0)
                    dp2[j] = Math.Min(dp2[j], dp2[stack.Peek()]);

                stack.Push(j);
            }

            (dp1, dp2) = (dp2, dp1);
        }

        return dp1[n - 1];

        #region UpdateMinDifficulty

        void UpdateMinDifficulty(int j)
        {
            while (stack.Count > 0 && jobDifficulty[stack.Peek()] <= jobDifficulty[j])
            {
                var k = stack.Pop();
                dp2[j] = Math.Min(dp2[j], dp2[k] - jobDifficulty[k] + jobDifficulty[j]);
            }
        }

        #endregion
    }
}
