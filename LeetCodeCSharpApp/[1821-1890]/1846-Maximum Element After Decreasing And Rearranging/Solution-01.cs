namespace LeetCodeCSharpApp.MaximumElementAfterDecreasingAndRearranging01;

public class Solution
{
    public int MaximumElementAfterDecrementingAndRearranging(int[] arr)
    {
        Array.Sort(arr);

        return arr.Aggregate(0, (current, n) => Math.Min(current + 1, n));
    }
}
