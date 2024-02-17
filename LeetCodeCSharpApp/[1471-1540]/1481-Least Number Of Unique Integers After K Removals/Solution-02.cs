// ReSharper disable IdentifierTypo

namespace LeetCodeCSharpApp.LeastNumberOfUniqueIntegersAfterKRemovals02;

/// <summary>
///     Min-heap
///
///     Time complexity: O(n * log(n))
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

        var frequencies = new PriorityQueue<int, int>();

        foreach (var frequency in map.Values)
            frequencies.Enqueue(frequency, frequency);

        var elementsRemoved = 0;

        while (frequencies.Count > 0)
        {
            elementsRemoved += frequencies.Peek();

            if (elementsRemoved > k)
                return frequencies.Count;

            frequencies.Dequeue();
        }

        return 0;
    }
}
