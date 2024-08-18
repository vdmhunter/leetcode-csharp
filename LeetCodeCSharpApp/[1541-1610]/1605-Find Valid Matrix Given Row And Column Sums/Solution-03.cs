namespace LeetCodeCSharpApp.FindValidMatrixGiven_RowAndColumnSums03;

public class Solution
{
    public int[][] RestoreMatrix(int[] rowSum, int[] colSum)
    {
        int n = rowSum.Length;
        int m = colSum.Length;

        var origMatrix = new int[n][];

        for (var i = 0; i < n; i++)
            origMatrix[i] = new int[m];

        int row = 0, col = 0;

        while (row < n && col < m)
        {
            origMatrix[row][col] = Math.Min(rowSum[row], colSum[col]);

            rowSum[row] -= origMatrix[row][col];
            colSum[col] -= origMatrix[row][col];

            if (rowSum[row] == 0)
                row++;
            else
                col++;
        }

        return origMatrix;
    }
}
