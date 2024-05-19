namespace LeetCodeCSharpApp.FindTheMaximumSumOfNodeValues01;

public class Solution
{
    public long MaximumValueSum(int[] nums, int k, int[][] edges)
    {
        long total = nums.Aggregate<int, long>(0, (current, num) => current + num);

        var totalDiff = 0L;
        var positiveCount = 0;
        var minAbsDiff = long.MaxValue;

        foreach (int num in nums)
        {
            long diff = (num ^ k) - num;

            if (diff > 0)
            {
                totalDiff += diff;
                positiveCount++;
            }

            minAbsDiff = Math.Min(minAbsDiff, Math.Abs(diff));
        }

        if (positiveCount % 2 == 1)
            totalDiff -= minAbsDiff;

        return total + totalDiff;
    }
}
