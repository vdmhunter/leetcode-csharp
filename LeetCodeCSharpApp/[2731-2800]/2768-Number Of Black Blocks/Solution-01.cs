namespace LeetCodeCSharpApp.NumberOfBlackBlocks01;

public class Solution
{
    public long[] CountBlackBlocks(int m, int n, int[][] coordinates)
    {
        var cnt = new Dictionary<(int, int), int>();

        foreach (var coordinate in coordinates)
        {
            var x = coordinate[0];
            var y = coordinate[1];

            IncreaseBlockCounts(cnt, x, y, m, n);
        }

        var tmp = CountValues(cnt);

        return new[]
        {
            (long)(n - 1) * (m - 1) - cnt.Count,
            tmp.GetValueOrDefault(1),
            tmp.GetValueOrDefault(2),
            tmp.GetValueOrDefault(3),
            tmp.GetValueOrDefault(4)
        };
    }

    private static void IncreaseBlockCounts(IDictionary<(int, int), int> cnt, int x, int y, int m, int n)
    {
        for (var i = x - 1; i <= x; i++)
        {
            for (var j = y - 1; j <= y; j++)
            {
                if (0 > i || i >= m - 1 || 0 > j || j >= n - 1)
                    continue;

                if (!cnt.ContainsKey((i, j)))
                    cnt[(i, j)] = 0;

                cnt[(i, j)]++;
            }
        }
    }

    private static Dictionary<int, int> CountValues(Dictionary<(int, int), int> cnt)
    {
        var tmp = new Dictionary<int, int>();

        foreach (var value in cnt.Values)
        {
            tmp.TryAdd(value, 0);
            tmp[value]++;
        }

        return tmp;
    }
}
