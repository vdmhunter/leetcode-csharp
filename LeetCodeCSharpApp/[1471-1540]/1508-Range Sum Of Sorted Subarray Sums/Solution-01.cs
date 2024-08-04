namespace LeetCodeCSharpApp.RangeSumOfSortedSubarraySums01;

public class Solution
{
    private const int Mod = 1_000_000_007;

    public int RangeSum(int[] nums, int n, int left, int right)
    {
        long result = (SumOfFirstK(nums, n, right) - SumOfFirstK(nums, n, left - 1)) % Mod;

        return (int)((result + Mod) % Mod);
    }

    private static KeyValuePair<int, long> CountAndSum(int[] nums, int n, int target)
    {
        var count = 0;
        long currentSum = 0, totalSum = 0, windowSum = 0;

        for (int j = 0, i = 0; j < n; j++)
        {
            currentSum += nums[j];
            windowSum += nums[j] * (j - i + 1);

            while (currentSum > target)
            {
                windowSum -= currentSum;
                currentSum -= nums[i++];
            }

            count += j - i + 1;
            totalSum += windowSum;
        }

        return new KeyValuePair<int, long>(count, totalSum);
    }

    private static long SumOfFirstK(int[] nums, int n, int k)
    {
        int minSum = nums.Min();
        int maxSum = nums.Sum();
        int left = minSum, right = maxSum;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (CountAndSum(nums, n, mid).Key >= k)
                right = mid - 1;
            else
                left = mid + 1;
        }

        KeyValuePair<int, long> result = CountAndSum(nums, n, left);

        return result.Value - left * (result.Key - k);
    }
}
