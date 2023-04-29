// ReSharper disable IdentifierTypo

namespace LeetCodeCSharpApp.NumberOfSubmatricesThatSumToTarget01;

public class Solution
{
    public int NumSubmatrixSumTarget(int[][] matrix, int target)
    {
        int result = 0, m = matrix.Length, n = matrix[0].Length;

        for (var i = 0; i < m; i++)
            for (var j = 1; j < n; j++)
                matrix[i][j] += matrix[i][j - 1];

        var counter = new Dictionary<int, int>();

        for (var i = 0; i < n; i++)
            for (var j = i; j < n; j++)
            {
                counter.Clear();
                counter[0] = 1;
                var cur = 0;

                for (var k = 0; k < m; k++)
                {
                    cur += matrix[k][j] - (i > 0 ? matrix[k][i - 1] : 0);
                    result += counter.ContainsKey(cur - target) ? counter[cur - target] : 0;
                    counter[cur] = (counter.ContainsKey(cur) ? counter[cur] : 0) + 1;
                }
            }

        return result;
    }
}
