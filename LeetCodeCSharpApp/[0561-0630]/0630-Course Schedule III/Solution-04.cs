namespace LeetCodeCSharpApp.CourseScheduleIII4;

/// <summary>
/// Extra List
/// </summary>
public class Solution
{
    public int ScheduleCourse(int[][] courses)
    {
        Array.Sort(courses, (a, b) => a[1] - b[1]);

        var validList = new List<int>();

        var time = 0;

        foreach (var c in courses)
            if (time + c[0] <= c[1])
            {
                validList.Add(c[0]);
                time += c[0];
            }
            else
            {
                var max = 0;

                for (var i = 1; i < validList.Count; i++)
                    if (validList[i] > validList[max])
                        max = i;

                if (validList.Count == 0 || validList[max] <= c[0])
                    continue;

                time += c[0] - validList[max];
                validList[max] = c[0];
            }

        return validList.Count;
    }
}
