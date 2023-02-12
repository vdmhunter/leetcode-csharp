namespace LeetCodeCSharpApp.ShortestPathWithAlternatingColors01;

public class Solution
{
    public int[] ShortestAlternatingPaths(int n, int[][] redEdges, int[][] blueEdges)
    {
        var adj = new Dictionary<int, List<List<int>>>();
         
        foreach (var redEdge in redEdges)
        {
            if (!adj.ContainsKey(redEdge[0]))
                adj[redEdge[0]] = new List<List<int>>();

            adj[redEdge[0]].Add(new List<int> { redEdge[1], 0 });
        }

        foreach (var blueEdge in blueEdges)
        {
            if (!adj.ContainsKey(blueEdge[0]))
                adj[blueEdge[0]] = new List<List<int>>();

            adj[blueEdge[0]].Add(new List<int> { blueEdge[1], 1 });
        }

        var result = new int[n];
        Array.Fill(result, -1);
        var visit = new bool[n][];
        
        for (var index = 0; index < visit.Length; ++index)
            visit[index] = new bool[2];

        var q = new Queue<int[]>();

        q.Enqueue(new[] { 0, 0, -1 });
        result[0] = 0;
        visit[0][1] = visit[0][0] = true;

        while (q.Count > 0)
        {
            var element = q.Dequeue();
            var node = element[0];
            var steps = element[1];
            var prevColor = element[2];

            if (!adj.ContainsKey(node))
                continue;

            foreach (var nei in adj[node])
            {
                var neighbor = nei[0];
                var color = nei[1];
                
                if (visit[neighbor][color] || color == prevColor)
                    continue;
                
                if (result[neighbor] == -1)
                    result[neighbor] = 1 + steps;

                visit[neighbor][color] = true;
                q.Enqueue(new[] { neighbor, 1 + steps, color });
            }
        }

        return result;
    }
}