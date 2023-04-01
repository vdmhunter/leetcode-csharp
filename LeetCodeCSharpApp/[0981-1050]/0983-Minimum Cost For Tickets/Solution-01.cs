// ReSharper disable IdentifierTypo
// ReSharper disable RedundantAssignment

namespace LeetCodeCSharpApp.MinimumCostForTickets01;

public class Solution
{
    public int MincostTickets(int[] days, int[] costs)
    {
        var (cDay, cWeek, cMonth) = (costs[0], costs[1], costs[2]);
        var d = new Dictionary<int, int>();

        return MinCost(0);

        int MinCost(int index)
        {
            if (index >= days.Length)
                return 0;

            if (d.ContainsKey(index))
                return d[index];

            var tIndex = index;

            while (tIndex < days.Length && days[tIndex] < days[index] + 7)
                tIndex++;

            var min = Math.Min(cDay + MinCost(index + 1), cWeek + MinCost(tIndex));

            tIndex = index;

            while (tIndex < days.Length && days[tIndex] < days[index] + 30)
                tIndex++;

            min = Math.Min(min, cMonth + MinCost(tIndex));
            d[index] = min;

            return min;
        }
    }
}
