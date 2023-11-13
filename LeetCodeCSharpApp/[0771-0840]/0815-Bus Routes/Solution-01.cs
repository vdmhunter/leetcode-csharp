namespace LeetCodeCSharpApp.BusRoutes01;

public class Solution
{
    private Queue<(int, int)> _bfs = null!;
    private Dictionary<int, HashSet<int>> _routeMap = null!;
    private int[][] _routes = null!;
    private bool[] _seenRoutes = null!;
    private HashSet<int> _seenStops = null!;

    public int NumBusesToDestination(int[][] routes, int source, int target)
    {
        _routes = routes;
        _routeMap = BuildRouteMap();
        _seenStops = new HashSet<int> { source };
        _seenRoutes = new bool[routes.Length];

        _bfs = new Queue<(int, int)>();
        _bfs.Enqueue((source, 0));

        while (_bfs.Count > 0)
        {
            var (stop, bus) = _bfs.Dequeue();

            if (stop == target)
                return bus;

            ProcessStop(stop, bus);
        }

        return -1;
    }

    private Dictionary<int, HashSet<int>> BuildRouteMap()
    {
        var routeMap = new Dictionary<int, HashSet<int>>();

        for (var i = 0; i < _routes.Length; ++i)
        {
            foreach (var stop in _routes[i])
            {
                if (!routeMap.ContainsKey(stop))
                    routeMap[stop] = new HashSet<int>();

                routeMap[stop].Add(i);
            }
        }

        return routeMap;
    }

    private void ProcessStop(int stop, int bus)
    {
        foreach (var route in _routeMap[stop].Where(route => !_seenRoutes[route]))
        {
            foreach (var nextStop in _routes[route])
            {
                if (_seenStops.Contains(nextStop))
                    continue;

                _seenStops.Add(nextStop);
                _bfs.Enqueue((nextStop, bus + 1));
            }

            _seenRoutes[route] = true;
        }
    }
}
