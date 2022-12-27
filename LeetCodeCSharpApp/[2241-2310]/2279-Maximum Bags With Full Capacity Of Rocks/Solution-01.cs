namespace LeetCodeCSharpApp.MaximumBagsWithFullCapacityOfRocks01;

public class Solution
{
    public int MaximumBags(int[] capacity, int[] rocks, int additionalRocks)
    {
        int n = rocks.Length, result = 0;

        for (var i = 0; i < n; i++)
            rocks[i] = capacity[i] - rocks[i];

        Array.Sort(rocks);

        for (var i = 0; i < n && rocks[i] - additionalRocks <= 0; i++)
        {
            result++;
            additionalRocks -= rocks[i];
        }

        return result;
    }
}
