namespace LeetCodeCSharpApp.DifferenceBetweenOnesAndZerosInRowAndColumn01;

public class Solution
{
    public int[][] OnesMinusZeros(int[][] grid)
    {
        var n = grid.Length;
        var m = grid[0].Length;

        var rows = grid.Select(row => row.Sum()).ToArray();
        var cols = Enumerable.Range(0, m).Select(j => grid.Sum(row => row[j])).ToArray();

        return grid.Select((row, i) => row.Select((_, j) => 2 * rows[i] + 2 * cols[j] - n - m).ToArray()).ToArray();
    }
}
