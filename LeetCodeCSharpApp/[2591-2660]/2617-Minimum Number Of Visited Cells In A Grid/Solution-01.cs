namespace LeetCodeCSharpApp.MinimumNumberOfVisitedCellsInAGrid01;

public class Solution
{
    public int MinimumVisitedCells(int[][] g)
    {
        var m = g.Length;
        var n = g[0].Length;
        var steps = 0;

        var maxI = new int[n];
        var maxJ = new int[m];

        var q1 = new List<int[]> { new[] { 0, 0 } };
        var q2 = new List<int[]>();

        while (q1.Count > 0)
        {
            ++steps;

            foreach (var pos in q1)
            {
                int i = pos[0], j = pos[1];

                if (i == m - 1 && j == n - 1)
                    return steps;

                FillQ2(q2, g, maxI, maxJ, i, j, m, n);

                maxI[j] = Math.Max(maxI[j], i + g[i][j]);
                maxJ[i] = Math.Max(maxJ[i], j + g[i][j]);
            }

            q1.Clear();
            q1.AddRange(q2);
            q2.Clear();
        }

        return -1;
    }

    private static void FillQ2(List<int[]> q2, int[][] g, int[] maxI, int[] maxJ, int i, int j, int m, int n)
    {
        for (var k = Math.Max(maxI[j], i) + 1; k < m && k - i <= g[i][j]; ++k)
            q2.Add(new[] { k, j });

        for (var k = Math.Max(maxJ[i], j) + 1; k < n && k - j <= g[i][j]; ++k)
            q2.Add(new[] { i, k });
    }
}
