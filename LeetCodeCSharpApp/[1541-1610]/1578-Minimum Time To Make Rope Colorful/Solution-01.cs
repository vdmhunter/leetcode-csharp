namespace LeetCodeCSharpApp.MinimumTimeToMakeRopeColorful01;

public class Solution
{
    public int MinCost(string colors, int[] neededTime)
    {
        int result = 0, max = neededTime[0];

        for (var i = 0; i < colors.Length - 1; i++)
            if (colors[i] == colors[i + 1])
            {
                result += Math.Min(max, neededTime[i + 1]);
                max = Math.Max(max, neededTime[i + 1]);
            }
            else
                max = neededTime[i + 1];

        return result;
    }
}
