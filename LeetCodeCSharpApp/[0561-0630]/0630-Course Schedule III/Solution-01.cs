namespace LeetCodeCSharpApp.CourseScheduleIII01;

/// <summary>
/// Recursion with Memoization
/// </summary>
public class Solution
{
    public int ScheduleCourse(int[][] courses)
    {
        Array.Sort(courses, (a, b) => a[1] - b[1]);
        var memo = new int[courses.Length][];

        for (var i = 0; i < memo.Length; i++)
            memo[i] = new int[courses[^1][1] + 1];

        return Schedule(courses, 0, 0, memo);
    }

    private static int Schedule(IReadOnlyList<int[]> courses, int i, int time, IReadOnlyList<int[]> memo)
    {
        if (i == courses.Count)
            return 0;

        if (memo[i][time] != 0)
            return memo[i][time];

        var taken = 0;

        if (time + courses[i][0] <= courses[i][1])
            taken = 1 + Schedule(courses, i + 1, time + courses[i][0], memo);

        var notTaken = Schedule(courses, i + 1, time, memo);
        
        memo[i][time] = Math.Max(taken, notTaken);

        return memo[i][time];
    }
}
