namespace LeetCodeCSharpApp.CountingBits01;

public class Solution
{
    public int[] CountBits(int n)
    {
        return Enumerable.Range(0, n + 1)
            .Select(i => Convert.ToString(i, 2).Count(c => c == '1'))
            .ToArray();
    }
}
