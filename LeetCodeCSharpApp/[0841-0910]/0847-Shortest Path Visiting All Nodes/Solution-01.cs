namespace LeetCodeCSharpApp.ShortestPathVisitingAllNodes01;

public class Solution
{
    public int ShortestPathLength(int[][] graph)
    {
        var n = graph.Length;
        var allVisited = (1 << n) - 1;
        var queue = new Queue<int[]>();
        var visited = new HashSet<int>();

        for (var i = 0; i < n; i++)
        {
            queue.Enqueue(new[] { 1 << i, i, 0 });
            visited.Add((1 << i) * 16 + i);
        }

        while (queue.Count > 0)
        {
            var cur = queue.Dequeue();

            if (cur[0] == allVisited) return cur[2];

            foreach (var neighbor in graph[cur[1]])
            {
                var newMask = cur[0] | (1 << neighbor);
                var hashValue = newMask * 16 + neighbor;

                if (visited.Contains(hashValue))
                    continue;

                visited.Add(hashValue);
                queue.Enqueue(new[] { newMask, neighbor, cur[2] + 1 });
            }
        }

        return -1;
    }
}
