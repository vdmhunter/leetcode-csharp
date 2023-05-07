namespace LeetCodeCSharpApp.FindTheLongestValidObstacleCourseAtEachPosition02;

public class Solution
{
    public int[] LongestObstacleCourseAtEachPosition(int[] obstacles)
    {
        var n = obstacles.Length;
        var length = 0;
        var result = new int[n];
        var arr = new int[n];

        for (var i = 0; i < n; ++i)
        {
            var l = 0;
            var r = length;

            while (l < r)
            {
                var m = (l + r) / 2;

                if (arr[m] <= obstacles[i])
                    l = m + 1;
                else
                    r = m;
            }

            result[i] = l + 1;

            if (length == l)
                length++;

            arr[l] = obstacles[i];
        }

        return result;
    }
}
