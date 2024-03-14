// ReSharper disable IdentifierTypo

namespace LeetCodeCSharpApp.BinarySubarraysWithSum03;

/// <summary>
///   Sliding Window in One Pass
///
///   Time complexity: O(N)
///   Space complexity: O(1)
/// </summary>
public class Solution
{
    public int NumSubarraysWithSum(int[] nums, int goal)
    {
        var start = 0;
        var prefixZeros = 0;
        var currentSum = 0;
        var totalCount = 0;

        for (var end = 0; end < nums.Length; end++)
        {
            currentSum += nums[end];

            while (start < end && (nums[start] == 0 || currentSum > goal))
            {
                if (nums[start] == 1)
                    prefixZeros = 0;
                else
                    prefixZeros++;

                currentSum -= nums[start];
                start++;
            }

            if (currentSum == goal)
                totalCount += 1 + prefixZeros;
        }

        return totalCount;
    }
}
