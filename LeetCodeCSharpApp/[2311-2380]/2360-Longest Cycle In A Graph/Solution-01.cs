namespace LeetCodeCSharpApp.LongestCycleInAGraph01;

public class Solution
{
    public int LongestCycle(int[] edges)
    {
        Dictionary<int, int> gd = new(), d = new();
        var result = 0;

        for (var i = 0; i < edges.Length; i++)
            if (!gd.ContainsKey(i))
            {
                d.Clear();
                result = Math.Max(result, Solve(i, 0));
            }

        if (result == 0)
            return -1;

        return result;

        int Solve(int position, int depth)
        {
            if (position == -1)
                return 0;

            if (gd.TryGetValue(position, out var solve))
                return solve;

            if (d.TryGetValue(position, out var value))
                return depth - value;

            d[position] = depth;

            var solution = Solve(edges[position], depth + 1);
            gd[position] = solution;

            return solution;
        }
    }
}
