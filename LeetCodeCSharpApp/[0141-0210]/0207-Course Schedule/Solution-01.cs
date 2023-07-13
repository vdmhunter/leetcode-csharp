namespace LeetCodeCSharpApp.CourseSchedule01;

public class Solution
{
    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        var indegree = new int[numCourses];
        var adjList = new List<int>[numCourses];

        BuildAdjacencyList(numCourses, prerequisites, indegree, adjList);

        var queue = FindInitialZeroIndegreeNodes(indegree);

        return ProcessGraph(numCourses, adjList, queue, indegree);
    }

    private static void BuildAdjacencyList(int numCourses, int[][] prerequisites, int[] indegree, List<int>[] adjList)
    {
        for (var i = 0; i < numCourses; i++)
            adjList[i] = new List<int>();

        foreach (var p in prerequisites)
        {
            adjList[p[1]].Add(p[0]);
            indegree[p[0]]++;
        }
    }

    private static Queue<int> FindInitialZeroIndegreeNodes(int[] indegree)
    {
        var queue = new Queue<int>();

        for (var i = 0; i < indegree.Length; i++)
            if (indegree[i] == 0)
                queue.Enqueue(i);

        return queue;
    }

    private static bool ProcessGraph(int numCourses, List<int>[] adjList, Queue<int> queue, int[] indegree)
    {
        var nodesVisited = queue.Count;

        while (queue.Any())
        {
            var node = queue.Dequeue();

            foreach (var neighbour in adjList[node])
            {
                // Decrease indegree for each neighbour
                if (--indegree[neighbour] != 0)
                    continue;

                nodesVisited++;
                queue.Enqueue(neighbour);
            }

            // If all nodes have been visited, return true
            if (nodesVisited == numCourses)
                return true;
        }

        // If not all nodes have been visited, it indicates there's a cycle
        return false;
    }
}
