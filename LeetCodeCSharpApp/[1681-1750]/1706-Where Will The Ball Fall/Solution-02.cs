namespace LeetCodeCSharpApp.WhereWillTheBallFall02;

public class Solution
{
    public int[] FindBall(int[][] grid)
    {
        int m = grid.Length, n = grid[0].Length;
        var result = new int[n];
        
        for (var i = 0; i < n; ++i)
        {
            var i1 = i;
            
            for (var j = 0; j < m; ++j)
            {
                var i2 = i1 + grid[j][i1];
                if (i2 < 0 || i2 >= n || grid[j][i2] != grid[j][i1])
                {
                    i1 = -1;
                    break;
                }

                i1 = i2;
            }

            result[i] = i1;
        }

        return result;
    }
}
