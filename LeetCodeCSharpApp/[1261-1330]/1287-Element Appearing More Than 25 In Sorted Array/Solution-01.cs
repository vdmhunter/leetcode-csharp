namespace LeetCodeCSharpApp.ElementAppearingMoreThan25InSortedArray01;

public class Solution
{
    public int FindSpecialInteger(int[] arr)
    {
        var n = arr.Length;
        var reqCount = n / 4;

        return arr.Where((t, i) => i < n - reqCount && t == arr[i + reqCount]).FirstOrDefault();
    }
}
