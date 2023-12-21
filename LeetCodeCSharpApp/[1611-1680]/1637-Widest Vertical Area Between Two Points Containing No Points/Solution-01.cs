namespace LeetCodeCSharpApp.WidestVerticalAreaBetweenTwoPointsContainingNoPoints01;

public class Solution
{
    public int MaxWidthOfVerticalArea(int[][] points)
    {
        var x = points.Select(p => p[0]).OrderBy(p => p).ToArray();

        return x.Skip(1).Zip(x, (a, b) => a - b).Max();
    }
}
