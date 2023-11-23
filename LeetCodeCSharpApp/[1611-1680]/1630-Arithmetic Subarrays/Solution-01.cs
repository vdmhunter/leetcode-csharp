namespace LeetCodeCSharpApp.ArithmeticSubarrays01;

public class Solution
{
    public IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r)
    {
        var result = new List<bool>(l.Length);

        for (var i = 0; i < l.Length; i++)
        {
            var slicedArray = SliceArray(nums, l[i], r[i]);
            Array.Sort(slicedArray);
            result.Add(IsArithmetic(slicedArray));
        }

        return result;
    }

    private static int[] SliceArray(int[] arr, int start, int stop)
    {
        var slicedArr = new int[stop - start + 1];

        for (var i = 0; start <= stop; i++)
            slicedArr[i] = arr[start++];

        return slicedArr;
    }

    private static bool IsArithmetic(int[] arr)
    {
        var diff = arr[1] - arr[0];

        for (var i = 0; i < arr.Length - 1; i++)
            if (arr[i + 1] - arr[i] != diff)
                return false;

        return true;
    }
}
