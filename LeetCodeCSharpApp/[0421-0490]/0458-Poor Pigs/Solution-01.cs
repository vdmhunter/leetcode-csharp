// ReSharper disable PossibleLossOfFraction

namespace LeetCodeCSharpApp.PoorPigs01;

public class Solution
{
    public int PoorPigs(int buckets, int minutesToDie, int minutesToTest)
    {
        if (buckets < 2)
            return 0;

        var n = 1;
        var c = 1;
        var x = 1 + minutesToTest / minutesToDie;

        while (x * n < buckets)
        {
            n = x * n;
            c++;
        }

        return c;
    }
}
