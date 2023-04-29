namespace LeetCodeCSharpApp.MaximumSumOfAnHourglass01;

public class Solution
{
    public int MaxSum(int[][] grid)
    {
        var result = int.MinValue;

        for (var m = 0; m <= grid.Length - 3; m++)
            for (var n = 0; n <= grid[0].Length - 3; n++)
                result = Math.Max(result, Sum(grid, m, n));

        return result;
    }

    private static int Sum(int[][] grid, int x, int y)
    {
        return grid[x][y] + grid[x][y + 1] + grid[x][y + 2]
               + grid[x + 1][y + 1]
               + grid[x + 2][y] + grid[x + 2][y + 1] + grid[x + 2][y + 2];
    }
}
