namespace LeetCodeCSharpApp.MaximumScoreFromPerformingMultiplicationOperations01;

public class Solution
{
    public int MaximumScore(int[] nums, int[] multipliers)
    {
        int[] lastRow = new int[multipliers.Length + 1], newRow = new int[multipliers.Length + 1];

        for (var i = 0; i < multipliers.Length; ++i)
        {
            for (var j = 1; j <= i; ++j)
                newRow[j] = Math.Max(
                    lastRow[j] + nums[^(i - j + 1)] * multipliers[i],
                    lastRow[j - 1] + nums[j - 1] * multipliers[i]);

            newRow[0] = lastRow[0] + nums[^(i + 1)] * multipliers[i];
            newRow[i + 1] = lastRow[i] + nums[i] * multipliers[i];

            (lastRow, newRow) = (newRow, lastRow);
        }

        return lastRow.Max();
    }
}
