namespace LeetCodeCSharpApp.MinimumTimeToMakeRopeColorful01;

public class Solution
{
    public int MinCost(string colors, int[] neededTime)
    {
        return Enumerable.Range(1, colors.Length - 1)
            .Where(i => colors[i] == colors[i - 1])
            .Sum(i =>
            {
                var minTime = Math.Min(neededTime[i], neededTime[i - 1]);
                neededTime[i] = Math.Max(neededTime[i], neededTime[i - 1]);

                return minTime;
            });
    }
}
