namespace LeetCodeCSharpApp.CourseScheduleIII3;

/// <summary>
///     Optimized Iterative
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
                courses[count++] = courses[i];
            }
            else
            {
                var max = i;
                
                for (var j = 0; j < count; j++)
                    if (courses[j][0] > courses[max][0])
                        max = j;
                
                if (courses[max][0] > courses[i][0])
                {
                    time += courses[i][0] - courses[max][0];
                    courses[max] = courses[i];
                }
            }

        return count;
    }
}
