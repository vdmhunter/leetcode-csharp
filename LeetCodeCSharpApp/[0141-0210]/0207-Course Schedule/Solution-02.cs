namespace LeetCodeCSharpApp.CourseSchedule02;

public class Solution
{
    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        var g = new List<int>[numCourses];
        var degree = new int[numCourses];
        var bfs = new List<int>();

        for (var i = 0; i < numCourses; ++i)
            g[i] = new List<int>();

        foreach (var e in prerequisites)
        {
            g[e[1]].Add(e[0]);
            degree[e[0]]++;
        }

        for (var i = 0; i < numCourses; ++i)
            if (degree[i] == 0)
                bfs.Add(i);

        for (var i = 0; i < bfs.Count; ++i)
            foreach (var j in g[bfs[i]])
                if (--degree[j] == 0)
                    bfs.Add(j);

        return bfs.Count == numCourses;
    }
}
