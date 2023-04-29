namespace LeetCodeCSharpApp.CourseScheduleIII02;

/// <summary>
///     Iterative Solution
/// </summary>
public class Solution
{
    public int ScheduleCourse(int[][] courses)
    {
        Array.Sort(courses, (a, b) => a[1] - b[1]);

        int time = 0, count = 0;

        for (var i = 0; i < courses.Length; i++)
            if (time + courses[i][0] <= courses[i][1])
            {
                time += courses[i][0];
                count++;
            }
            else
            {
                var max = i;

                for (var j = 0; j < i; j++)
                    if (courses[j][0] > courses[max][0])
                        max = j;

                if (courses[max][0] > courses[i][0])
                {
                    time += courses[i][0] - courses[max][0];
                }

                courses[max][0] = -1;
            }

        return count;
    }
}
