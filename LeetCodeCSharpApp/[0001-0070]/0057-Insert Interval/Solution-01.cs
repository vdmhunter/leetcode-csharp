namespace LeetCodeCSharpApp.InsertInterval01;

public class Solution
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        if (intervals.Length == 0)
            return new[] { newInterval };

        var result = new List<int[]>();

        foreach (var interval in intervals)
            if (newInterval[0] > interval[1])
            {
                result.Add(interval);
            }

            else if (newInterval[1] < interval[0])
            {
                result.Add(newInterval);
                newInterval = interval;
            }

            else
            {
                newInterval[0] = Math.Min(interval[0], newInterval[0]);
                newInterval[1] = Math.Max(interval[1], newInterval[1]);
            }

        result.Add(newInterval);

        return result.ToArray();
    }
}
