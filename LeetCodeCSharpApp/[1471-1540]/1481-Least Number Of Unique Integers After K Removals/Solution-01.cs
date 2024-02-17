// ReSharper disable IdentifierTypo

namespace LeetCodeCSharpApp.LeastNumberOfUniqueIntegersAfterKRemovals01;

/// <summary>
///     Sorting the Frequencies
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

        var frequencies = new List<int>(map.Values);
        frequencies.Sort();

        var elementsRemoved = 0;

        for (var i = 0; i < frequencies.Count; i++)
        {
            elementsRemoved += frequencies[i];

            if (elementsRemoved > k)
                return frequencies.Count - i;
        }

        return 0;
    }
}
