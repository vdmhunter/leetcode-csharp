// ReSharper disable IdentifierTypo

namespace LeetCodeCSharpApp.BinarySubarraysWithSum01;

/// <summary>
///   Prefix Sum
///
///   Time complexity: O(N)
///   Space complexity: O(N)
/// </summary>
public class Solution
{
    public int NumSubarraysWithSum(int[] nums, int goal)
    {
        var totalCount = 0;
        var currentSum = 0;
        var freq = new Dictionary<int, int>(); // To store the frequency of prefix sums

        foreach (int num in nums)
        {
            currentSum += num;

            if (currentSum == goal)
                totalCount++;

            if (freq.ContainsKey(currentSum - goal))
                totalCount += freq[currentSum - goal];

            if (freq.TryGetValue(currentSum, out int value))
                freq[currentSum] = ++value;
            else
                freq.Add(currentSum, 1);
        }

        return totalCount;
    }
}
