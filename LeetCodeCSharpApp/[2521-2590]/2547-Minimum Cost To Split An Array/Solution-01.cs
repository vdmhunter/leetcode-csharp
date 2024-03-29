namespace LeetCodeCSharpApp.MinimumCostToSplitAnArray01;

public class Solution
{
    public int MinCost(int[] nums, int k)
    {
        var memo = new int[nums.Length];

        return FindMinCost(0, nums, k, memo);
    }

    private int FindMinCost(int idx, int[] nums, int k, int[] memo)
    {
        if (idx == nums.Length)
            return 0;

        if (memo[idx] > 0)
            return memo[idx];

        Dictionary<int, int> d = new();
        int minSubArrayCost = int.MaxValue, currSubArrayCost = k;

        for (var i = idx; i < nums.Length; i++)
        {
            if (!d.ContainsKey(nums[i]))
                d.Add(nums[i], 0);

            d[nums[i]]++;
            currSubArrayCost += d[nums[i]] <= 1 ? 0 : d[nums[i]] == 2 ? 2 : 1;
            minSubArrayCost = Math.Min(minSubArrayCost, FindMinCost(i + 1, nums, k, memo) + currSubArrayCost);
        }

        return memo[idx] = minSubArrayCost;
    }
}
