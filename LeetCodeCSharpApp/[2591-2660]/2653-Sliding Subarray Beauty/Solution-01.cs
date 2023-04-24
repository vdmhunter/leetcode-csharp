namespace LeetCodeCSharpApp.SlidingSubarrayBeauty01;

public class Solution
{
    public int[] GetSubarrayBeauty(int[] nums, int k, int x)
    {
        var n = nums.Length;
        var result = new int[n - k + 1];
        var negatives = new List<int>();

        InitNegatives(negatives, nums, k);

        negatives.Sort();
        result[0] = negatives.Count >= x ? negatives[x - 1] : 0;

        for (var i = k; i < n; i++)
        {
            if (nums[i - k] < 0)
                negatives.Remove(nums[i - k]);

            if (nums[i] < 0)
            {
                var index = negatives.BinarySearch(nums[i]);

                if (index < 0)
                    index = ~index;

                negatives.Insert(index, nums[i]);
            }

            result[i - k + 1] = negatives.Count >= x ? negatives[x - 1] : 0;
        }

        return result;
    }

    private static void InitNegatives(List<int> negatives, int[] nums, int k)
    {
        for (var i = 0; i < k; i++)
            if (nums[i] < 0)
                negatives.Add(nums[i]);
    }
}
