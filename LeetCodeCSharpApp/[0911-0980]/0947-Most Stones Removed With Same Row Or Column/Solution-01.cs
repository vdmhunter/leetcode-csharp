namespace LeetCodeCSharpApp.MostStonesRemovedWithSameRowOrColumn01;

// https://leetcode.com/problems/most-stones-removed-with-same-row-or-column/solutions/197668/count-the-number-of-islands-o-n/

public class Solution
{
    private readonly Dictionary<int, int> _f = new();
    private int _islands;

    public int RemoveStones(int[][] stones)
    {
        foreach (var stone in stones)
            Union(stone[0], ~stone[1]);

        return stones.Length - _islands;
    }

    private void Union(int x, int y)
    {
        x = Find(x);
        y = Find(y);

        if (x == y)
            return;

        _f[x] = y;
        _islands--;
    }

    private int Find(int x)
    {
        if (!_f.ContainsKey(x))
        {
            _f.Add(x, x);
            _islands++;
        }

        if (x != _f[x])
            _f[x] = Find(_f[x]);

        return _f[x];
    }
}
