namespace LeetCodeCSharpApp.BusRoutes01;

public class Solution
{
    public int NumBusesToDestination(int[][] routes, int source, int target)
    {
        var routeMap = BuildRouteMap(routes);

        return CalculateMinimumBuses(routeMap, routes, source, target);
    }

    private static Dictionary<int, HashSet<int>> BuildRouteMap(int[][] routes)
    {
        var routeMap = new Dictionary<int, HashSet<int>>();

        for (var i = 0; i < routes.Length; ++i)
        {
            foreach (var stop in routes[i])
            {
                if (!routeMap.ContainsKey(stop))
                    routeMap[stop] = new HashSet<int>();

                routeMap[stop].Add(i);
            }
        }

        return routeMap;
    }

    private static int CalculateMinimumBuses(Dictionary<int, HashSet<int>> routeMap, int[][] routes, int source,
        int target)
    {
        var bfs = new Queue<(int, int)>();
        bfs.Enqueue((source, 0));

        var seenStops = new HashSet<int> { source };
        var seenRoutes = new bool[routes.Length];

        while (bfs.Count > 0)
        {
            var (stop, bus) = bfs.Dequeue();

            if (stop == target)
                return bus;

            ProcessStop(routeMap, routes, bfs, seenStops, seenRoutes, stop, bus);
        }

        return -1;
    }

    private static void ProcessStop(Dictionary<int, HashSet<int>> routeMap, int[][] routes, Queue<(int, int)> bfs,
        HashSet<int> seenStops, bool[] seenRoutes, int stop, int bus)
    {
        foreach (var route in routeMap[stop].Where(route => !seenRoutes[route]))
        {
            foreach (var nextStop in routes[route])
            {
                if (seenStops.Contains(nextStop))
                    continue;

                seenStops.Add(nextStop);
                bfs.Enqueue((nextStop, bus + 1));
            }

            seenRoutes[route] = true;
        }
    }
}
