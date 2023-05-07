namespace LeetCodeCSharpApp.FindTheLongestValidObstacleCourseAtEachPosition01;

public class Solution
{
    public int[] LongestObstacleCourseAtEachPosition(int[] obstacles)
    {
        var list = new List<int>();

        for (var i = 0; i < obstacles.Length; i++)
        {
            var x = obstacles[i];

            if (list.Count == 0 || list[^1] <= x)
            {
                list.Add(x);
                obstacles[i] = list.Count;
            }
            else
            {
                var idx = FindIndex(list, x);
                UpdateList(list, idx, x);
                obstacles[i] = idx + 1;
            }
        }

        return obstacles;
    }

    private static int FindIndex(List<int> list, int x)
    {
        var idx = list.BinarySearch(x);

        if (idx < 0)
            idx = ~idx;
        else
            idx += 1;

        while (idx < list.Count && list[idx] <= x)
            idx += 1;

        return idx;
    }

    private static void UpdateList(List<int> list, int idx, int x)
    {
        if (idx == list.Count)
            list.Add(x);
        else
            list[idx] = x;
    }
}

