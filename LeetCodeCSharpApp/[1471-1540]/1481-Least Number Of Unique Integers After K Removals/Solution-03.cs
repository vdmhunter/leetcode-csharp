// ReSharper disable IdentifierTypo

namespace LeetCodeCSharpApp.LeastNumberOfUniqueIntegersAfterKRemovals03;

/// <summary>
///     Counting Sort
///
///     Time complexity: O(n))
///     Space complexity: O(n)
/// </summary>
public class Solution
{
    public int FindLeastNumOfUniqueInts(int[] arr, int k)
    {
        var map = new Dictionary<int, int>();

        foreach (var i in arr)
            if (map.TryGetValue(i, out var value))
                map[i] = ++value;
            else
                map[i] = 1;

        var n = arr.Length;
        var countOfFrequencies = new int[n + 1];

        foreach (var count in map.Values)
            countOfFrequencies[count]++;

        var remainingUniqueElements = map.Count;

        for (var i = 1; i <= n; i++)
        {
            var numElementsToRemove = Math.Min(k / i, countOfFrequencies[i]);
            k -= i * numElementsToRemove;
            remainingUniqueElements -= numElementsToRemove;

            if (k < i)
                return remainingUniqueElements;
        }

        return 0;
    }
}
