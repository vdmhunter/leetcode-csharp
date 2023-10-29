// ReSharper disable PossibleLossOfFraction

namespace LeetCodeCSharpApp.PoorPigs02;

public class Solution
{
    public int PoorPigs(int buckets, int minutesToDie, int minutesToTest)
    {
        return (int)Math.Ceiling(Math.Log(buckets) / Math.Log(minutesToTest / minutesToDie + 1));
    }
}
