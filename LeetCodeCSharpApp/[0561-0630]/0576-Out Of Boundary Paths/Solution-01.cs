namespace LeetCodeCSharpApp.OutOfBoundaryPaths01;

/// <summary>
/// Brute Force
/// </summary>
public class Solution
{
    public int FindPaths(int m, int n, int maxMove, int startRow, int startColumn)
    {
        if (startRow == m || startColumn == n || startRow < 0 || startColumn < 0)
            return 1;

        if (maxMove == 0)
            return 0;

        return FindPaths(m, n, maxMove - 1, startRow - 1, startColumn) +
               FindPaths(m, n, maxMove - 1, startRow + 1, startColumn) +
               FindPaths(m, n, maxMove - 1, startRow, startColumn - 1) +
               FindPaths(m, n, maxMove - 1, startRow, startColumn + 1);
    }
}
