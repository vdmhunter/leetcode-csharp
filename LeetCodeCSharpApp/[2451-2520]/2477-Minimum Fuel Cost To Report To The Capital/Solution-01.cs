namespace LeetCodeCSharpApp.MinimumFuelCostToReportToTheCapital01;

public class Solution
{
    private long _result;
    private int _s;

    public long MinimumFuelCost(int[][] roads, int seats)
    {
        var graph = new List<IList<int>>();
        _s = seats;

        for (var i = 0; i < roads.Length + 1; i++)
            graph.Add(new List<int>());

        foreach (var r in roads)
        {
            graph[r[0]].Add(r[1]);
            graph[r[1]].Add(r[0]);
        }

        Dfs(0, 0, graph);

        return _result;
    }

    private int Dfs(int i, int prev, List<IList<int>> graph)
    {
        var people = 1 + graph[i].Where(x => x != prev).Sum(x => Dfs(x, i, graph));

        if (i != 0)
            _result += (people + _s - 1) / _s;

        return people;
    }
}
