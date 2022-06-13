namespace LeetCodeCSharpApp.RangeSumQuery2DImmutable;

public class NumMatrix 
{
    private readonly int[][]? _dp;

    public NumMatrix(int[][] matrix)
    {
        if (matrix.Length == 0 || matrix[0].Length == 0)
            return;
        
        _dp = new int[matrix.Length][];
        
        for (var r = 0; r < matrix.Length; r++)
        {
            _dp[0] = new int[matrix[0].Length + 1];
            
            for (var c = 0; c < matrix[0].Length; c++)
                _dp[r][c + 1] = _dp[r][c] + matrix[r][c];
        }
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2)
    {
        var sum = 0;
        
        for (var row = row1; row <= row2; row++)
            sum += _dp![row][col2 + 1] - _dp[row][col1];

        return sum;
    }
}
