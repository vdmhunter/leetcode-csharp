// ReSharper disable IdentifierTypo

namespace LeetCodeCSharpApp.MaxSumOfRectangleNoLargerThanK01;

public class Solution
{
    private int[][]? _sums;
    public int MaxSumSubmatrix(int[][] matrix, int k)
    {
        int rows = matrix.Length, cols = matrix[0].Length;

        _sums = new int[rows + 1][];
        for (var i = 0; i <= rows; i++)
            _sums[i] = new int[cols + 1];

        var result = int.MinValue;
        
        for (var i = 0; i < rows; i++)
            for (var j = 0; j < cols; j++)
            {
                _sums[i + 1][j + 1] = _sums[i + 1][j] + _sums[i][j + 1] - _sums[i][j] + matrix[i][j];

                if (RectangleSum(i, j, k, ref result, out var submatrixSum))
                    return submatrixSum;
            }

        return result;
    }

    private bool RectangleSum(int i, int j, int k, ref int result, out int submatrixSum)
    {
        submatrixSum = result;
        
        for (var rectangleHeight = 0; rectangleHeight <= i; rectangleHeight++)
            for (var rectangleWidth = 0; rectangleWidth <= j; rectangleWidth++)
            {
                var rectangleSum = _sums![i + 1][j + 1] - _sums[i + 1][j - rectangleWidth] -
                    _sums[i - rectangleHeight][j + 1] + _sums[i - rectangleHeight][j - rectangleWidth];

                if (rectangleSum == k)
                {
                    submatrixSum = rectangleSum;
                    return true;
                }

                result = rectangleSum < k
                    ? Math.Max(result, rectangleSum)
                    : result;
            }

        return false;
    }
}
