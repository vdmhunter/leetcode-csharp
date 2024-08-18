namespace LeetCodeCSharpApp.FindValidMatrixGiven_RowAndColumnSums02;

public class Solution
{
    public int[][] RestoreMatrix(int[] rowSum, int[] colSum)
    {
        int n = rowSum.Length;
        int m = colSum.Length;

        var origMatrix = new int[n][];

        for (var i = 0; i < n; i++)
        {
            origMatrix[i] = new int[m];

            for (var j = 0; j < m; j++)
            {
                origMatrix[i][j] = Math.Min(rowSum[i], colSum[j]);

                rowSum[i] -= origMatrix[i][j];
                colSum[j] -= origMatrix[i][j];
            }
        }

        return origMatrix;
    }
}
