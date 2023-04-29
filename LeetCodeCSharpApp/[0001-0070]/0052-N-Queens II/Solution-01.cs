namespace LeetCodeCSharpApp.NQueensII;

public class Solution
{
    private int _ans;

    /// <summary>
    /// 1-d array represents the current board state
    /// board[i] indicates the column which the queen positioned (on ith row)
    /// space: O(n)
    /// </summary>
    private int[]? _board;

    public int TotalNQueens(int n)
    {
        _ans = 0;
        _board = new int[n];

        Search(0);

        return _ans;
    }

    private void Search(int row)
    {
        var n = _board!.Length;

        if (row == n)
            _ans++;
        else
        {
            // time: O(n)
            for (var col = 0; col < n; col++)
            {
                _board[row] = col;

                if (IsValid(row))
                    Search(row + 1);
            }
        }
    }

    /// <summary>
    /// Helper function to check if the current position of queen at `row` is valid
    /// time: O(row)
    /// </summary>
    private bool IsValid(int row)
    {
        var curCol = _board![row];

        for (var i = 1; i <= row; i++)
        {
            var col = _board[row - i];

            if (col == curCol || col == curCol - i || col == curCol + i)
                return false;
        }

        return true;
    }
}
