namespace LeetCodeCSharpApp.MinCostClimbingStairs01;

public class Solution
{
    public int MinCostClimbingStairs(int[] cost)
    {
        for (var i = 2; i < cost.Length; i++)
            cost[i] += Math.Min(cost[i - 1], cost[i - 2]);
        
        return Math.Min(cost[^1], cost[^2]);
    }
}
