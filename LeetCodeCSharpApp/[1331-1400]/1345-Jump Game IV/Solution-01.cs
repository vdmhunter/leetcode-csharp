namespace LeetCodeCSharpApp.JumpGameIV01;

public class Solution
{
    public int MinJumps(int[] arr)
    {
        var n = arr.Length;
        var visited = new bool[n];
        var adj = new Dictionary<int, List<int>>();

        for (var i = 0; i < n; i++)
            if (!adj.ContainsKey(arr[i]))
                adj.Add(arr[i], new List<int> { i });
            else
                adj[arr[i]].Add(i);

        var q = new Queue<int>();
        var steps = 0;

        q.Enqueue(0);
        visited[0] = true;

        while (q.Count > 0)
        {
            var size = q.Count;

            for (var i = 0; i < size; i++)
            {
                var ind = q.Dequeue();

                if (ind == n - 1)
                    return steps;

                //Move front (i + 1)
                if (ind + 1 < n && visited[ind + 1] == false)
                    q.Enqueue(ind + 1);

                //Move back (i - 1)
                if (ind - 1 >= 0 && visited[ind - 1] == false)
                {
                    q.Enqueue(ind - 1);
                    visited[ind - 1] = true;
                }

                //Move to index with same value
                foreach (var nei in adj[arr[ind]].Where(nei => visited[nei] == false))
                {
                    visited[nei] = true;
                    q.Enqueue(nei);
                }

                adj[arr[ind]].Clear();
            }

            steps++;
        }

        return steps;
    }
}
