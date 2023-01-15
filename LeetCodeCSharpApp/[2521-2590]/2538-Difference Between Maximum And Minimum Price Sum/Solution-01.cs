namespace LeetCodeCSharpApp.DifferenceBetweenMaximumAndMinimumPriceSum01;

public class Solution
{
    // Pre calculating result for current node with previous node
    private readonly Dictionary<(int, int), long> _dp = new();

    // Graph storage
    private readonly Dictionary<int, List<int>> _storage = new();

    // Storing price in class level so no need to pass in every method
    private int[] _price;

    public long MaxOutput(int n, int[][] edges, int[] price)
    {
        _price = price;

        for (var i = 0; i < n; i++)
            _storage.Add(i, new List<int>());

        foreach (var e in edges)
        {
            _storage[e[0]].Add(e[1]);
            _storage[e[1]].Add(e[0]);
        }

        long result = 0;

        for (var i = 0; i < n; i++)
            result = Math.Max(result, MaxOutputInner(i, -1) - price[i]);

        return result;
    }

    private long MaxOutputInner(int node, int prevNode)
    {
        // Checking if value already exist
        if (_dp.TryGetValue((node, prevNode), out var value))
            return value;

        long currentResult = _price[node];

        var childResult = (from item in _storage[node] where item != prevNode select MaxOutputInner(item, node))
            .Prepend(0L)
            .Max();

        var result = currentResult + childResult;

        // Saving value in dp
        _dp.Add((node, prevNode), result);

        return result;
    }
}
