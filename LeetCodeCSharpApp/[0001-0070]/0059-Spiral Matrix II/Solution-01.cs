namespace LeetCodeCSharpApp.SpiralMatrixII01;

public class Solution
{
    public int[][] GenerateMatrix(int n)
    {
        var num = 1;
        var result = new int[n][];

        for (var i = 0; i < n; i++)
            result[i] = new int[n];

        for (int i = 0, j = n - 1; i <= j; i++, j--)
        {
            for (var k = i; k <= j; k++)
                result[i][k] = num++;
            for (var k = i + 1; k <= j; k++)
                result[k][j] = num++;
            for (var k = j - 1; k >= i; k--)
                result[j][k] = num++;
            for (var k = j - 1; k > i; k--)
                result[k][i] = num++;
        }

        return result;
    }
}
