namespace LeetCodeCSharpApp.SortIntegersByTheNumberOf1Bits02;

public class Solution
{
    private readonly Dictionary<int, int> _weightCache = new();

    public int[] SortByBits(int[] arr)
    {
        Array.Sort(arr, (a, b) =>
        {
            var weightA = FindWeight(a);
            var weightB = FindWeight(b);

            return weightA == weightB
                ? a.CompareTo(b)
                : weightA.CompareTo(weightB);
        });

        return arr;
    }

    private int FindWeight(int num)
    {
        if (_weightCache.TryGetValue(num, out var findWeight))
            return findWeight;

        var weight = 0;
        var temp = num;

        while (temp > 0)
        {
            weight++;
            temp &= temp - 1;
        }

        _weightCache[num] = weight;

        return weight;
    }
}
