namespace LeetCodeCSharpApp.FindTheWidthOfColumnsOfAGrid01;

public class Solution
{
    public int[] FindColumnWidth(int[][] grid)
    {
        var result = new int[grid[0].Length];

        for (var i = 0; i < grid[0].Length; i++)
        {
            var max = grid.Select(e => e[i].ToString().Length).Prepend(0).Max();
            result[i] = max;
        }

        return result;
    }
}
