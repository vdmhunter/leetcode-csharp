namespace LeetCodeCSharpApp.MinimumTimeToMakeRopeColorful02;

public class Solution
{
    public int MinCost(string colors, int[] neededTime)
    {
        var n = colors.Length;
        var totalTime = 0;

        for (var i = 1; i < n; i++)
        {
            if (colors[i] != colors[i - 1])
                continue;

            totalTime += Math.Min(neededTime[i], neededTime[i - 1]);
            neededTime[i] = Math.Max(neededTime[i], neededTime[i - 1]);
        }

        return totalTime;
    }
}
