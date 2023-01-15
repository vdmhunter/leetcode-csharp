// ReSharper disable IdentifierTypo

namespace LeetCodeCSharpApp.IncrementSubmatricesByOne01;

public class Solution
{
    public int[][] RangeAddQueries(int n, int[][] queries)
    {
        var mat = new int[n][];

        for (var i = 0; i < n; i++)
            mat[i] = new int[n];

        foreach (var q in queries)
            for (var i = q[0]; i <= q[2]; i++)
                for (var j = q[1]; j <= q[3]; j++)
                    mat[i][j] += 1;

        return mat;
    }
}
