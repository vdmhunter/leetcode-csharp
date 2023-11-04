namespace LeetCodeCSharpApp.LastMomentBeforeAllAntsFallOutOfAPlank01;

public class Solution
{
    public int GetLastMoment(int n, int[] left, int[] right)
    {
        return right.Select(i => n - i).Prepend(left.Prepend(0).Max()).Max();
    }
}
