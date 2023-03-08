namespace LeetCodeCSharpApp.KthMissingPositiveNumber01;

public class Solution
{
    public int FindKthPositive(int[] arr, int k)
    {
        return Enumerable.Range(1, 1000000).Except(arr).ToArray()[k - 1];
    }
}
