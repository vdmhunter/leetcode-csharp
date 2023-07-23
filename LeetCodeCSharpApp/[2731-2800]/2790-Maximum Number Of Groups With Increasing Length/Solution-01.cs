namespace LeetCodeCSharpApp.MaximumNumberOfGroupsWithIncreasingLength01;

public class Solution
{
    public int MaxIncreasingGroups(IList<int> usageLimits)
    {
        var sortedUsageLimits = usageLimits.OrderBy(l => l);
        var total = 0L;
        var count = 0;

        foreach (var l in sortedUsageLimits)
        {
            total += l;

            if (total >= (count + 1) * (count + 2) / 2)
                count += 1;
        }

        return count;
    }
}
