namespace LeetCodeCSharpApp.CourseScheduleIII5;

/// <summary>
/// Priority Queue
/// </summary>
public class Solution
{
    public int ScheduleCourse(int[][] courses)
    {
        Array.Sort(courses, (a, b) => a[1] - b[1]);
        
        var queue = new PriorityQueue<int, int>();
        
        var time = 0;
        
        foreach (var c in courses)
            if (time + c[0] <= c[1])
            {
                queue.Enqueue(c[0], -c[0]);
                time += c[0];
            }
            else if (queue.Count != 0 && queue.Peek() > c[0])
            {
                time += c[0] - queue.Dequeue();
                queue.Enqueue(c[0], -c[0]);
            }

        return queue.Count;
    }
}
