// ReSharper disable IdentifierTypo

namespace LeetCodeCSharpApp.FindAGoodSubsetOfTheMatrix01;

public class Solution
{
    public IList<int> GoodSubsetofBinaryMatrix(int[][] grid)
    {
        var n = grid.Length;
        var list = GetList(grid);

        for (var i = 0; i < n; i++)
        {
            if (list[i] == 0)
                return new List<int> { i };

            for (var j = i + 1; j < n; j++)
                if ((list[i] & list[j]) == 0)
                    return new List<int> { i, j };
        }

        return new List<int>();
    }

    private static List<int> GetList(int[][] grid)
    {
        var m = grid[0].Length;
        var result = new List<int>();

        foreach (var i in grid)
        {
            var num = 0;

            for (var j = 0; j < m; j++)
                num |= i[j] << j;

            result.Add(num);
        }

        return result;
    }
}
