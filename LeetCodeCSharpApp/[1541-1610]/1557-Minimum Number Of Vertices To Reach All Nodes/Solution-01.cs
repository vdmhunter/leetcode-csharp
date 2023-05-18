namespace LeetCodeCSharpApp.MinimumNumberOfVerticesToReachAllNodes01;

public class Solution
{
    public IList<int> FindSmallestSetOfVertices(int n, IList<IList<int>> edges)
    {
        var result = new List<int>();
        var set = new HashSet<int>();

        foreach (var e in edges)
            set.Add(e[1]);

        for (var i = 0; i < n; i++)
            if (!set.Contains(i))
                result.Add(i);

        return result;
    }
}
