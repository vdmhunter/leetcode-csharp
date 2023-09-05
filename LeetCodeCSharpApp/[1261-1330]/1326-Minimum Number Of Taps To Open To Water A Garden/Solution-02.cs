namespace LeetCodeCSharpApp.MinimumNumberOfTapsToOpenToWaterAGarden02;

public class Solution
{
    public int MinTaps(int n, int[] ranges)
    {
        var arr = Enumerable.Repeat(0, n + 1).ToArray();

        for (var i = 0; i < ranges.Length; i++)
        {
            if (ranges[i] == 0)
                continue;

            var left = Math.Max(0, i - ranges[i]);
            arr[left] = Math.Max(arr[left], i + ranges[i]);
        }

        int wateredUpTo = 0, maxReach = 0, count = 0;

        for (var i = 0; i <= n; i++)
        {
            if (i > wateredUpTo)
            {
                if (maxReach <= wateredUpTo)
                    return -1;

                wateredUpTo = maxReach;
                count++;
            }

            maxReach = Math.Max(maxReach, arr[i]);
        }

        return count + (wateredUpTo < n ? 1 : 0);
    }
}
