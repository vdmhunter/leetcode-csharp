namespace LeetCodeCSharpApp.FindAllPeopleWithSecret05;

/// <summary>
///     Union-Find with Reset
///
///     Time complexity: O(m * log(m) + n)
///     Space complexity: O(m + n)
/// </summary>
public class Solution
{
    public IList<int> FindAllPeople(int n, int[][] meetings, int firstPerson)
    {
        Array.Sort(meetings, (a, b) => a[2].CompareTo(b[2]));

        Dictionary<int, List<int[]>> sameTimeMeetings = meetings
            .GroupBy(m => m[2])
            .ToDictionary(
                g => g.Key,
                g => g.Select(m => new[] { m[0], m[1] }).ToList()
            );

        var graph = new UnionFind(n);
        graph.Unite(firstPerson, 0);

        foreach (int t in sameTimeMeetings.Keys)
        {
            foreach (int[] meeting in sameTimeMeetings[t])
            {
                int x = meeting[0], y = meeting[1];
                graph.Unite(x, y);
            }

            foreach (int[] meeting in sameTimeMeetings[t])
            {
                int x = meeting[0], y = meeting[1];

                if (graph.Connected(x, 0))
                    continue;

                graph.Reset(x);
                graph.Reset(y);
            }
        }

        return Enumerable.Range(0, n).Where(i => graph.Connected(i, 0)).ToList();
    }
}

public class UnionFind
{
    private readonly int[] _parent;
    private readonly int[] _rank;

    public UnionFind(int n)
    {
        _parent = new int[n];
        _rank = new int[n];

        for (var i = 0; i < n; i++)
            _parent[i] = i;
    }

    private int Find(int x)
    {
        if (_parent[x] != x)
            _parent[x] = Find(_parent[x]);

        return _parent[x];
    }

    public void Unite(int x, int y)
    {
        int px = Find(x);
        int py = Find(y);

        if (px == py)
            return;

        if (_rank[px] > _rank[py])
        {
            _parent[py] = px;
        }
        else if (_rank[px] < _rank[py])
        {
            _parent[px] = py;
        }
        else
        {
            _parent[py] = px;
            _rank[px] += 1;
        }
    }

    public bool Connected(int x, int y)
    {
        return Find(x) == Find(y);
    }

    public void Reset(int x)
    {
        _parent[x] = x;
        _rank[x] = 0;
    }
}
