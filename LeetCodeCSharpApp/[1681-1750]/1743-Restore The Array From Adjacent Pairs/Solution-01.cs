namespace LeetCodeCSharpApp.RestoreTheArrayFromAdjacentPairs01;

public class Solution
{
    public int[] RestoreArray(int[][] adjacentPairs)
    {
        var ps = new Dictionary<int, List<int>>();

        foreach (var p in adjacentPairs)
        {
            if (!ps.ContainsKey(p[0]))
                ps[p[0]] = new List<int>();

            if (!ps.ContainsKey(p[1]))
                ps[p[1]] = new List<int>();

            ps[p[0]].Add(p[1]);
            ps[p[1]].Add(p[0]);
        }

        var result = new List<int>();

        foreach (var p in ps.Where(p => p.Value.Count == 1))
        {
            result.Add(p.Key);
            result.Add(p.Value[0]);

            break;
        }

        while (result.Count < adjacentPairs.Length + 1)
        {
            var tail = result[^1];
            var prev = result[^2];
            var next = ps[tail];

            result.Add(next[0] != prev ? next[0] : next[1]);
        }

        return result.ToArray();
    }
}
