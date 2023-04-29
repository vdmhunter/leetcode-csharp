namespace LeetCodeCSharpApp.RangeSumQueryMutable02;

/// <summary>
/// Segment tree solution
/// </summary>
public class NumArray
{
    private readonly int _len;
    private readonly int[] _segmentTree;

    public NumArray(int[] nums)
    {
        _len = nums.Length;
        _segmentTree = BuildSegmentTree(new int[GetNextPowerOfTwo(_len) * 2 - 1], nums, 0, _len - 1, 0);
    }

    public void Update(int index, int val)
    {
        UpdateSegmentTree(_segmentTree, index, val, 0, _len - 1, 0);
    }

    public int SumRange(int left, int right)
    {
        return QuerySumRange(0, _len - 1, left, right, 0);
    }

    private int GetNextPowerOfTwo(int n)
    {
        int m = n,
            cnt = 0;

        if (n > 0 && (n & (n - 1)) == 0)
            return n;

        while (m != 0)
        {
            m = m >> 1;
            cnt++;
        }

        return 1 << cnt;
    }

    private int[] BuildSegmentTree(int[] segmentTree, int[] input, int l, int r, int pos)
    {
        if (l == r)
        {
            segmentTree[pos] = input[l];
        }
        else
        {
            var mid = l + (r - l) / 2;

            BuildSegmentTree(segmentTree, input, l, mid, pos * 2 + 1);
            BuildSegmentTree(segmentTree, input, mid + 1, r, pos * 2 + 2);

            segmentTree[pos] = segmentTree[pos * 2 + 1] + segmentTree[pos * 2 + 2];
        }

        return segmentTree;
    }

    private void UpdateSegmentTree(int[] segmentTree, int i, int val, int l, int r, int pos)
    {
        if (i < l || r < i)
            return;

        if (l == r)
            segmentTree[pos] = val;
        else
        {
            var mid = l + (r - l) / 2;

            UpdateSegmentTree(segmentTree, i, val, l, mid, pos * 2 + 1);
            UpdateSegmentTree(segmentTree, i, val, mid + 1, r, pos * 2 + 2);

            segmentTree[pos] = segmentTree[pos * 2 + 1] + segmentTree[pos * 2 + 2];
        }
    }

    private int QuerySumRange(int l, int r, int queryL, int queryR, int pos)
    {
        if (queryL <= l && r <= queryR)
            return _segmentTree[pos];

        if (queryL > r || queryR < l)
            return 0;

        var mid = l + (r - l) / 2;

        return QuerySumRange(l, mid, queryL, queryR, pos * 2 + 1) +
               QuerySumRange(mid + 1, r, queryL, queryR, pos * 2 + 2);
    }
}
