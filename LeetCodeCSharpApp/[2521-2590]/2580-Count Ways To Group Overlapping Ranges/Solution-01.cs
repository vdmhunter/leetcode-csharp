namespace LeetCodeCSharpApp.CountWaysToGroupOverlappingRanges01;

public class Solution
{
    private const int Mod = 1_000_000_007;

    public int CountWays(int[][] ranges)
    {
        int result = 1, last = -1;
        Array.Sort(ranges, (x, y) => x[0] - y[0]);

        foreach (var r in ranges)
        {
            if (last < r[0])
                result = result * 2 % Mod;
            
            last = Math.Max(last, r[1]);
        }

        return result;
    }
}
