namespace LeetCodeCSharpApp.WhereWillTheBallFall01;

public class Solution
{
    public int[] FindBall(int[][] grid)
    {
        var rows = grid.Length;
        var cols = grid[0].Length;
        var result = new int[cols];

        for (var j = 0; j < cols; j++)
        {
            var curr = j;
            for (var i = 0; i < rows; i++)
                if (grid[i][curr] == 1)
                {
                    if (curr == cols - 1 || grid[i][curr + 1] == -1)
                    {
                        result[j] = -1;
                        break;
                    }

                    curr++;
                }
                else
                {
                    if (curr == 0 || grid[i][curr - 1] == 1)
                    {
                        result[j] = -1;
                        break;
                    }

                    curr--;
                }

            if (result[j] == 0)
                result[j] = curr;
        }

        return result;
    }
}
