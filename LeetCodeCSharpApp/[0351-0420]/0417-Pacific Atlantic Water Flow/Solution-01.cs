namespace LeetCodeCSharpApp.PacificAtlanticWaterFlow01;

public class Solution
{
    public IList<IList<int>> PacificAtlantic(int[][] heights)
    {
        var m = heights.Length;

        if (m == 0)
            return new List<IList<int>>();

        var n = heights[0].Length;

        var reachableToPacific = new bool[m, n];
        var reachableToAtlantic = new bool[m, n];

        void Search(int i, int j, bool[,] reachable)
        {
            if (reachable[i, j])
                return;

            reachable[i, j] = true;

            if (i > 0 && heights[i - 1][j] >= heights[i][j])
                Search(i - 1, j, reachable);

            if (j > 0 && heights[i][j - 1] >= heights[i][j])
                Search(i, j - 1, reachable);

            if (i < m - 1 && heights[i + 1][j] >= heights[i][j])
                Search(i + 1, j, reachable);

            if (j < n - 1 && heights[i][j + 1] >= heights[i][j])
                Search(i, j + 1, reachable);
        }

        for (var i = 0; i < m; i++)
            Search(i, 0, reachableToPacific);

        for (var i = 0; i < m; i++)
            Search(i, n - 1, reachableToAtlantic);

        for (var j = 0; j < n; j++)
            Search(0, j, reachableToPacific);

        for (var j = 0; j < n; j++)
            Search(m - 1, j, reachableToAtlantic);

        var result = new List<IList<int>>();

        for (var i = 0; i < m; i++)
            for (var j = 0; j < n; j++)
                if (reachableToPacific[i, j] && reachableToAtlantic[i, j])
                    result.Add(new List<int> { i, j });

        return result;
    }
}
