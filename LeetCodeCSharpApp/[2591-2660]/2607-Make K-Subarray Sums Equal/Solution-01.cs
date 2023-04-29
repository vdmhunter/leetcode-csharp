namespace LeetCodeCSharpApp.MakeKSubarraySumsEqual01;

public class Solution
{
    public long MakeSubKSumEqual(int[] arr, int k)
    {
        var result = 0L;
        var shift = GetMin(arr.Length, k);

        for (var i = 0; i < shift; i++)
        {
            var list = GetIthList(i, shift, arr);
            result += GetMin(list);
        }

        return result;
    }

    private static long GetMin(List<int> list)
    {
        list.Sort();
        var val = list[list.Count / 2];

        return list.Aggregate(0L, (current, n) => current + Math.Abs(n - val));
    }

    private static List<int> GetIthList(int index, int shift, int[] arr)
    {
        var result = new List<int>();

        for (var i = index; i < arr.Length; i += shift)
            result.Add(arr[i]);

        return result;
    }

    private static int GetMin(int n, int k) => n % k == 0 ? k : GetMin(k, n % k);
}
