namespace LeetCodeCSharpApp.FindTheHighestAltitude01;

public class Solution
{
    public int LargestAltitude(int[] gain)
    {
        if (gain == null)
            return 0;

        var n = gain.Length;
        var accumulatedGain = new int[n + 1];

        for (var i = 1; i <= n; i++)
            accumulatedGain[i] = accumulatedGain[i - 1] + gain[i - 1];

        return accumulatedGain.Max();
    }
}
