namespace LeetCodeCSharpApp.FindNearestPointThatHasTheSameXOrYCoordinate01;

public class Solution
{
    public int NearestValidPoint(int x, int y, int[][] points)
    {
        var index = -1;

        for (int i = 0, smallest = int.MaxValue; i < points.Length; ++i)
        {
            int dx = x - points[i][0], dy = y - points[i][1];

            if (dx * dy != 0 || Math.Abs(dy + dx) >= smallest)
                continue;

            smallest = Math.Abs(dx + dy);
            index = i;
        }

        return index;
    }
}
