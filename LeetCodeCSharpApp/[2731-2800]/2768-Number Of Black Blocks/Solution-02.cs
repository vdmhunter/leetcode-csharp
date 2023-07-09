namespace LeetCodeCSharpApp.NumberOfBlackBlocks02;

public class Solution
{
    public long[] CountBlackBlocks(int m, int n, int[][] coordinates)
    {
        var mp = new Dictionary<long, int>();

        foreach (var c in coordinates)
            IncreaseBlockCounts(mp, c[0], c[1], m, n);

        var result = CountValues(mp);

        result[0] = (long)(m - 1) * (n - 1);
        result[0] = result[0] - result[1] - result[2] - result[3] - result[4];

        return result;
    }

    private static void IncreaseBlockCounts(Dictionary<long, int> mp, int x, int y, int m, int n)
    {
        IncreaseBlockCount(mp, x, y, m, n);
        IncreaseBlockCount(mp, x - 1, y, m, n);
        IncreaseBlockCount(mp, x, y - 1, m, n);
        IncreaseBlockCount(mp, x - 1, y - 1, m, n);
    }

    private static void IncreaseBlockCount(Dictionary<long, int> mp, int x, int y, int m, int n)
    {
        if (x < 0 || x >= m - 1 || y < 0 || y >= n - 1)
            return;

        if (!mp.ContainsKey(y * 1000000L + x))
            mp[y * 1000000L + x] = 0;

        mp[y * 1000000L + x]++;
    }

    private static long[] CountValues(Dictionary<long, int> mp)
    {
        var result = new long[] { 0, 0, 0, 0, 0 };

        foreach (var item in mp)
            result[item.Value]++;

        return result;
    }
}
