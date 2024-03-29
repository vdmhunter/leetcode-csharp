namespace LeetCodeCSharpApp.MinimumReverseOperations01;

public class Solution
{
    public int[] MinReverseOperations(int n, int p, int[] banned, int k)
    {
        var bs = new HashSet<int>(banned) { p };

        SortedSet<int>[] choice =
        {
            new(Enumerable.Range(0, n).Where(i => i % 2 == 0).Except(bs)),
            new(Enumerable.Range(0, n).Where(i => i % 2 == 1).Except(bs))
        };

        IEnumerable<int> Rotate(int pos)
        {
            var l = Math.Max(pos - k + 1, 0) * 2 + k - 1 - pos;
            var r = Math.Min(pos + 1, n - k + 1) * 2 + k - 1 - pos;
            var currChoice = choice[l % 2];
            var result = currChoice.GetViewBetween(l, r - 1).ToList();

            foreach (var i in result)
                currChoice.Remove(i);

            return result;
        }

        var bfs = new List<int> { p };
        var visited = new Dictionary<int, int> { { p, 0 } };

        for (var i = 0; i < bfs.Count; i++)
        {
            var vi = visited[bfs[i]] + 1;

            foreach (var j in Rotate(bfs[i]).Where(j => !visited.ContainsKey(j)))
            {
                visited[j] = vi;
                bfs.Add(j);
            }
        }

        var result = Enumerable.Repeat(-1, n).ToArray();

        foreach (var pair in visited)
            result[pair.Key] = pair.Value;

        return result;
    }
}
