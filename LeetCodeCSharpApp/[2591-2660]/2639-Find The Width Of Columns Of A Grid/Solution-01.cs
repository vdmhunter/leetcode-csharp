namespace LeetCodeCSharpApp.FindTheWidthOfColumnsOfAGrid01;

public class Solution
{
    public int[] FindColumnWidth(int[][] grid)
    {
        var result = new int[grid[0].Length];

        for (var i = 0; i < grid[0].Length; i++)
            result[i] = grid.Select(e => e[i].ToString().Length).Max();

        return result;
    }
}
