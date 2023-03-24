namespace LeetCodeCSharpApp.ReorderRoutesToMakeAllPathsLeadToTheCityZero01;

public class Solution
{
    private readonly Dictionary<int, List<(int city, bool direction)>> _graph = new();
    private readonly HashSet<int> _visited = new();
    private int _result;

    public int MinReorder(int n, int[][] connections)
    {
        foreach (var connection in connections)
        {
            var cityA = connection[0];
            var cityB = connection[1];

            _graph[cityA] = _graph.GetValueOrDefault(cityA, new List<(int, bool)>());
            _graph[cityA].Add((cityB, true));

            _graph[cityB] = _graph.GetValueOrDefault(cityB, new List<(int, bool)>());
            _graph[cityB].Add((cityA, false));
        }

        Dfs(0);

        return _result;
    }

    private void Dfs(int city)
    {
        _visited.Add(city);

        foreach (var (node, direction) in _graph[city])
        {
            if (_visited.Contains(node))
                continue;

            if (direction)
                ++_result;

            Dfs(node);
        }
    }
}
