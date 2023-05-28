namespace LeetCodeCSharpApp.DifferenceOfNumberOfDistinctValuesOnDiagonals01;

public class Solution
{
    public int[][] DifferenceOfDistinctValues(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;
        var result = CreateResultArray(m, n);

        for (var r = 0; r < m; r++)
            for (var c = 0; c < n; c++)
            {
                var topLeft = GetDistinctValues(grid, r, c, -1, -1);
                var bottomRight = GetDistinctValues(grid, r, c, 1, 1);

                result[r][c] = Math.Abs(topLeft.Count - bottomRight.Count);
            }

        return result;
    }

    private static int[][] CreateResultArray(int m, int n)
    {
        var result = new int[m][];

        for (var i = 0; i < m; i++)
            result[i] = new int[n];

        return result;
    }

    private HashSet<int> GetDistinctValues(int[][] grid, int r, int c, int rowStep, int colStep)
    {
        var distinctValues = new HashSet<int>();

        for (var i = 1; IsValidIndex(grid, r, c, rowStep * i, colStep * i); i++)
        {
            var row = r + rowStep * i;
            var col = c + colStep * i;
            distinctValues.Add(grid[row][col]);
        }

        return distinctValues;
    }

    private static bool IsValidIndex(int[][] grid, int r, int c, int rowOffset, int colOffset)
    {
        var newRow = r + rowOffset;
        var newCol = c + colOffset;

        return newRow >= 0 && newRow < grid.Length && newCol >= 0 && newCol < grid[0].Length;
    }
}
