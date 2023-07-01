namespace LeetCodeCSharpApp.MinimumCostToMakeArrayEqual01;

public class Solution
{
    public long MinCost(int[] nums, int[] cost)
    {
        var n = nums.Length;
        var left = 1_000_000L;
        var right = 0L;

        for (var i = 0; i < n; i++)
        {
            if (nums[i] < left)
                left = nums[i];

            if (nums[i] > right)
                right = nums[i];
        }

        while (left <= right)
        {
            var mid = (left + right) / 2;

            if (FindCost(nums, cost, mid) < FindCost(nums, cost, mid + 1))
                right = mid - 1;
            else
                left = mid + 1;
        }

        return FindCost(nums, cost, left);
    }

    private static long FindCost(int[] nums, int[] cost, long left)
    {
        var result = 0L;

        for (var i = 0; i < nums.Length; i++)
            result += Math.Abs(nums[i] - left) * cost[i];

        return result;
    }
}
