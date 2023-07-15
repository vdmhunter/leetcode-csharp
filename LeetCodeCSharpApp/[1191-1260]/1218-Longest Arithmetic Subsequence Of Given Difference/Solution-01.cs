namespace LeetCodeCSharpApp.LongestArithmeticSubsequenceOfGivenDifference01;

public class Solution
{
    public int LongestSubsequence(int[] arr, int diff)
    {
        var dict = new Dictionary<int, int>();

        return arr.Select(n => dict[n] = dict.GetValueOrDefault(n - diff) + 1).Prepend(1).Max();
    }
}
