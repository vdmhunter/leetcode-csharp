namespace LeetCodeCSharpApp.MinimumNumberOfArrowsToBurstBalloons01;

public class Solution
{
    public int FindMinArrowShots(int[][] points)
    {
        Array.Sort(points, (a, b) => a[1].CompareTo(b[1]));
        int result = 0, arrow = 0;

        foreach (var point in points)
        {
            if (result != 0 && point[0] <= arrow)
                continue;

            result++;
            arrow = point[1];
        }

        return result;
    }
}
