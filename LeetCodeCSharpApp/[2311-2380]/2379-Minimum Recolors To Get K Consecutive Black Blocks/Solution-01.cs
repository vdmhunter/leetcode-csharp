namespace LeetCodeCSharpApp.MinimumRecolorsToGetKConsecutiveBlackBlocks01;

public class Solution
{
    public int MinimumRecolors(string blocks, int k)
    {
        var min = int.MaxValue;

        for (var i = 0; i <= blocks.Length - k; i++)
        {
            var cnt = blocks.Substring(i, k).Count(c => c == 'W');
            min = Math.Min(min, cnt);
        }

        return min;
    }
}
