namespace LeetCodeCSharpApp.MaximumStrictlyIncreasingCellsInAMatrix01;

public class Solution
{
    public int MaxIncreasingCells(int[][] mat)
    {
        var m = mat.Length;
        var n = mat[0].Length;
        var valuePositions = GetValuePositions(mat);

        var dp = Enumerable.Range(0, m).Select(_ => new int[n]).ToArray();
        var maxPathLengths = CalculateMaxPathLengths(dp, valuePositions, m, n);

        return maxPathLengths.Max();
    }

    private static SortedDictionary<int, List<int[]>> GetValuePositions(int[][] mat)
    {
        var result = new SortedDictionary<int, List<int[]>>();

        for (var i = 0; i < mat.Length; i++)
        {
            for (var j = 0; j < mat[0].Length; j++)
            {
                var val = mat[i][j];

                if (!result.ContainsKey(val))
                    result[val] = new List<int[]>();

                result[val].Add(new[] { i, j });
            }
        }

        return result;
    }

    private static int[] CalculateMaxPathLengths(int[][] dp, SortedDictionary<int, List<int[]>> vp, int m, int n)
    {
        var result = new int[n + m];

        foreach (var key in vp.Keys)
        {
            foreach (var pos in vp[key])
            {
                var i = pos[0];
                var j = pos[1];
                dp[i][j] = Math.Max(result[i], result[m + j]) + 1;
            }

            foreach (var pos in vp[key])
            {
                var i = pos[0];
                var j = pos[1];
                result[m + j] = Math.Max(result[m + j], dp[i][j]);
                result[i] = Math.Max(result[i], dp[i][j]);
            }
        }

        return result;
    }
}
