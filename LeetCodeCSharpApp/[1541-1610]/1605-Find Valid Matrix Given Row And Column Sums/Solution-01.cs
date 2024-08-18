namespace LeetCodeCSharpApp.FindValidMatrixGiven_RowAndColumnSums01;

public class Solution
{
    public int[][] RestoreMatrix(int[] rowSum, int[] colSum)
    {
        int n = rowSum.Length;
        int m = colSum.Length;

        var currRowSum = new int[n];
        var currColSum = new int[m];

        var origMatrix = new int[n][];

        for (var i = 0; i < n; i++)
        {
            origMatrix[i] = new int[m];

            for (var j = 0; j < m; j++)
            {
                origMatrix[i][j] = Math.Min(rowSum[i] - currRowSum[i], colSum[j] - currColSum[j]);
                currRowSum[i] += origMatrix[i][j];
                currColSum[j] += origMatrix[i][j];
            }
        }

        return origMatrix;
    }
}
