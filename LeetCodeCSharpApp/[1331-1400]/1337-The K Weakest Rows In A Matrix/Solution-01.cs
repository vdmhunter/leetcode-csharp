namespace LeetCodeCSharpApp.TheKWeakestRowsInAMatrix01;

public class Solution
{
    public int[] KWeakestRows(int[][] mat, int k)
    {
        return mat.Select((row, idx) => (row: row.Sum(), idx))
            .OrderBy(i => i.row)
            .Select(i => i.idx)
            .ToArray()[..k];
    }
}
