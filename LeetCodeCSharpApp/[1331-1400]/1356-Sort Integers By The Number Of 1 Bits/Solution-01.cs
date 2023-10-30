namespace LeetCodeCSharpApp.SortIntegersByTheNumberOf1Bits01;

public class Solution
{
    public int[] SortByBits(int[] arr)
    {
        Array.Sort(arr, (a, b) => NumberOf1(a) - NumberOf1(b) == 0 ? a - b : NumberOf1(a) - NumberOf1(b));

        return arr;

        int NumberOf1(int i) => Convert.ToString(i, 2).Count(c => c == '1');
    }
}
