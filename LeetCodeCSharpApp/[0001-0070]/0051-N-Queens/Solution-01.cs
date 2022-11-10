namespace LeetCodeCSharpApp.NQueens;

public class Solution
{
    private int[][]? _board;
    
    public IList<IList<string>> SolveNQueens(int n)
    {
        _board = new int[n][];

        for (var row = 0; row < n ; row++)
            _board[row] = new int[n];

        var result = new List<IList<string>>();
        
        SolveNQueens(0, result);
        
        return result;
    }
    
    private void SolveNQueens(int col, IList<IList<string>> result)
    {
        if (col == _board!.Length)
        {
            var list = ToListOfString(_board);
            
            result.Add(list);
        }
        else
        {
            for (var r = 0; r < _board.Length; r++)
            {
                if (!IsSafeToPlace(r, col))
                    continue;
                
                _board[r][col] = 1;

                SolveNQueens(col + 1, result);

                _board[r][col] = 0;
            }
        }
    }
    
    private bool IsSafeToPlace(int row, int col)
    {
        if (!IsSafeVertical(row, col))
            return false;

        if (!IsSafeDiagonal1(row, col))
            return false;

        if (!IsSafeDiagonal2(row, col))
            return false;

        return true;
    }
    
    private bool IsSafeVertical(int row, int col)
    {
        for (var c = col; c >= 0; c--)
            if (_board![row][c] == 1)
                return false;
        return true;
    }
    
    private bool IsSafeDiagonal1(int row, int col)
    {
        for (int r = row, c = col; r >= 0 && c >= 0; r--, c--)
            if (_board![r][c] == 1)
                return false;
        
        return true;
    }
    
    private bool IsSafeDiagonal2(int row, int col)
    {
        for (int r = row, c = col; r < _board!.Length && c >= 0; r++, c--)
            if (_board[r][c] == 1)
                return false;
        
        return true;
    }
    
    private static List<string> ToListOfString(IReadOnlyList<int[]> board)
    {
        var result = new List<string>();
        
        foreach (var row in board)
        {
            var sb = new System.Text.StringBuilder();
            
            for (var j = 0; j < board[0].Length; j++)
                sb.Append(row[j] == 1 ? "Q" : ".");

            result.Add(sb.ToString());
        }
        
        return result;
    }
}
