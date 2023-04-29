namespace LeetCodeCSharpApp.DisconnectPathInABinaryMatrixByAtMostOneFlip01;

public class Solution
{
    private static readonly int[][] Dirs = { new[] { 0, 1 }, new[] { 1, 0 } };

    public bool IsPossibleToCutPath(int[][] grid)
    {
        Dfs(grid, 0, 0);
        var second = Dfs(grid, 0, 0);

        return second < 1;
    }

    private static int Dfs(int[][] g, int r, int c)
    {
        if (r < 0 || r >= g.Length || c < 0 || c >= g[0].Length || g[r][c] == 0)
            return 0;

        if (r == g.Length - 1 && c == g[0].Length - 1)
            return 1;

        if (!(r == 0 && c == 0))
            g[r][c] = 0;

        return Count(g, r, c, 0);
    }

    private static int Count(int[][] g, int r, int c, int count)
    {
        foreach (var dir in Dirs)
        {
            count += Dfs(g, r + dir[0], c + dir[1]);

            if (count >= 1)
                break;
        }

        return count;
    }
}
