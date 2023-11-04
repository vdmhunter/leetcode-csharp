namespace LeetCodeCSharpApp.LastMomentBeforeAllAntsFallOutOfAPlank02;

public class Solution
{
    public int GetLastMoment(int n, int[] left, int[] right)
    {
        return left.Union(right.Select(x => n - x)).DefaultIfEmpty(0).Max();
    }
}
