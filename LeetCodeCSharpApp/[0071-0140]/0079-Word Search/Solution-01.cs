namespace LeetCodeCSharpApp.WordSearch01;

public class Solution
{
    public bool Exist(char[][] board, string word)
    {
        for (var i = 0; i < board.Length; i++)
            for (var j = 0; j < board[0].Length; j++)
                if (Exist(board, i, j, word, 0))
                    return true;

        return false;
    }

    private static bool Exist(char[][] board, int i, int j, string word, int ind)
    {
        if (ind == word.Length)
            return true;

        if (i > board.Length - 1 || i < 0 || j < 0 || j > board[0].Length - 1 || board[i][j] != word[ind])
            return false;

        board[i][j] = '*';
        var result = Exist(board, i - 1, j, word, ind + 1) ||
                     Exist(board, i, j - 1, word, ind + 1) ||
                     Exist(board, i, j + 1, word, ind + 1) ||
                     Exist(board, i + 1, j, word, ind + 1);
        board[i][j] = word[ind];

        return result;
    }
}
