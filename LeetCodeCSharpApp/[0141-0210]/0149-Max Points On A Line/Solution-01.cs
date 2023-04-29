namespace LeetCodeCSharpApp.MaxPointsOnALine01;

public class Solution
{
    public int MaxPoints(int[][] points)
    {
        var result = 0;

        for (var i = 0; i < points.Length; i++)
        {
            var dic = new Dictionary<double, int>();
            var max = 0;

            for (var j = i + 1; j < points.Length; j++)
            {
                var slope = GetSlope(points[i], points[j]);

                dic.TryAdd(slope, 0);

                dic[slope]++;
                max = Math.Max(max, dic[slope]);
            }

            result = Math.Max(result, max + 1);
        }

        return result;
    }

    private static double GetSlope(int[] point1, int[] point2)
    {
        double dx = point2[0] - point1[0];
        double dy = point2[1] - point1[1];

        if (dx == 0)
            return double.MaxValue;

        return dy / dx;
    }
}
