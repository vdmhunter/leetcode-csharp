using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.SpiralMatrixIV01;

public class Solution
{
    public int[][] SpiralMatrix(int m, int n, ListNode head)
    {
        var matrix = new int[m][];
        for (var i = 0; i < m; i++)
        {
            var arr = new int[n];
            Array.Fill(arr, -1);
            matrix[i] = arr;
        }

        if (n == 0 || m == 0) return matrix;

        var rowStart = 0;
        var rowEnd = m - 1;
        var colStart = 0;
        var colEnd = n - 1;
        var ln = head;

        while (rowStart <= rowEnd && colStart <= colEnd)
        {
            for (var i = colStart; i <= colEnd; i++)
            {
                if (ln == null)
                    return matrix;

                matrix[rowStart][i] = ln.val;
                ln = ln.next;
            }

            rowStart++;

            for (var i = rowStart; i <= rowEnd; i++)
            {
                if (ln == null)
                    return matrix;

                matrix[i][colEnd] = ln.val;
                ln = ln.next;
            }

            colEnd--;

            for (var i = colEnd; i >= colStart; i--)
                if (rowStart <= rowEnd)
                {
                    if (ln == null)
                        return matrix;

                    matrix[rowEnd][i] = ln.val;
                    ln = ln.next;
                }

            rowEnd--;

            for (var i = rowEnd; i >= rowStart; i--)
                if (colStart <= colEnd)
                {
                    if (ln == null)
                        return matrix;

                    matrix[i][colStart] = ln.val;
                    ln = ln.next;
                }

            colStart++;
        }

        return matrix;
    }
}
