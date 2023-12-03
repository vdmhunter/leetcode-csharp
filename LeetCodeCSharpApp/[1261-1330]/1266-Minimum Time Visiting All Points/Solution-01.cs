namespace LeetCodeCSharpApp.MinimumTimeVisitingAllPoints01;

public class Solution
{
    public int MinTimeToVisitAllPoints(int[][] points)
    {
        var time = 0;

        for (var i = 1; i < points.Length; i++)
            time += ToTime(points[i - 1], points[i]);

        return time;
    }

    private static int ToTime(int[] from, int[] to)
    {
        var xDiff = Math.Abs(from[0] - to[0]);
        var yDiff = Math.Abs(from[1] - to[1]);

        return Math.Max(xDiff, yDiff);
    }
}
