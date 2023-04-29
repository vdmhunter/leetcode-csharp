namespace LeetCodeCSharpApp.LargestLocalValuesInAMatrix01;

public class Solution
{
    public int[][] LargestLocal(int[][] grid)
    {
        var n = grid.Length;
        var result = new int[n - 2][];

        for (var i = 1; i < n - 1; i++)
        {
            result[i - 1] = new int[n - 2];

            for (var j = 1; j < n - 1; j++)
                result[i - 1][j - 1] = MaxLocal(i, j);
        }

        int MaxLocal(int i, int j)
        {
            var max = 0;

            for (var ii = i - 1; ii <= i + 1; ii++)
                for (var jj = j - 1; jj <= j + 1; jj++)
                    max = Math.Max(max, grid[ii][jj]);

            return max;
        }

        return result;
    }
}
