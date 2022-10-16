namespace LeetCodeCSharpApp.CountSubarraysWithFixedBounds01;

public class Solution
{
    public long CountSubarrays(int[] nums, int minK, int maxK)
    {
        long result = 0, j = 0, min = -1, max = -1, n = nums.Length;

        for (var i = 0; i < n; ++i)
        {
            if (nums[i] < minK || nums[i] > maxK)
            {
                min = max = -1;
                j = i + 1;
            }

            if (nums[i] == minK)
                min = i;

            if (nums[i] == maxK)
                max = i;

            result += Math.Max(0L, Math.Min(min, max) - j + 1);
        }

        return result;
    }
}
