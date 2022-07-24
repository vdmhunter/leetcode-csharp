namespace LeetCodeCSharpApp.EqualRowAndColumnPairs02;

public class Solution
{
    public int EqualPairs(int[][] grid)
    {
        var n = grid.Length;
        var result = 0;
        
        for (var i = 0; i < n; i++)
            for (var j = 0; j < n; j++)
            {
                var b = true;
                
                for (var k = 0; k < n; k++)
                    if (grid[i][k] != grid[k][j])
                    {
                        b = false;
                        break;
                    }
                
                result += b ? 1 : 0;
            }

        return result;
    }
}
