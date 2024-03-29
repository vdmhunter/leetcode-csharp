namespace LeetCodeCSharpApp.MakeKSubarraySumsEqual02;

public class Solution
{
    public long MakeSubKSumEqual(int[] arr, int k)
    {
        var result = 0L;
        var size = arr.Length;

        for (var i = 0; i < size; ++i)
        {
            var cycle = new List<int>();

            for (var j = i; arr[j] != 0; j = (j + k) % size)
            {
                cycle.Add(arr[j]);
                arr[j] = 0;
            }

            cycle.Sort();
            var median = cycle.Count != 0 ? cycle[cycle.Count / 2] : 0;
            result = cycle.Aggregate(result, (current, n) => current + Math.Abs(n - median));
        }

        return result;
    }
}
