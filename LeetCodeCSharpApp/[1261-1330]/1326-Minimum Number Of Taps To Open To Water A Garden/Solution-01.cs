namespace LeetCodeCSharpApp.MinimumNumberOfTapsToOpenToWaterAGarden01;

public class Solution
{
    public int MinTaps(int n, int[] ranges)
    {
        int wateredUpTo = 0, maxReach = 0, count = 0;

        while (maxReach < n)
        {
            for (var i = 0; i < ranges.Length; i++)
                if (i - ranges[i] <= wateredUpTo && i + ranges[i] >= maxReach)
                    maxReach = i + ranges[i];

            if (maxReach == wateredUpTo)
                return -1;

            count++;
            wateredUpTo = maxReach;
        }

        return count;
    }
}
