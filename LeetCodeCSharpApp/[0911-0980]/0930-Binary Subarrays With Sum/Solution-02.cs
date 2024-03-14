// ReSharper disable IdentifierTypo

namespace LeetCodeCSharpApp.BinarySubarraysWithSum02;

/// <summary>
///   Sliding Window
///
///   Time complexity: O(N)
///   Space complexity: O(1)
/// </summary>
public class Solution
{
    public int NumSubarraysWithSum(int[] nums, int goal)
    {
        return SlidingWindowAtMost(nums, goal) - SlidingWindowAtMost(nums, goal - 1);
    }

    private static int SlidingWindowAtMost(int[] nums, int goal)
    {
        int start = 0, currentSum = 0, totalCount = 0;

        for (var end = 0; end < nums.Length; end++)
        {
            currentSum += nums[end];

            while (start <= end && currentSum > goal)
                currentSum -= nums[start++];

            totalCount += end - start + 1;
        }

        return totalCount;
    }
}
