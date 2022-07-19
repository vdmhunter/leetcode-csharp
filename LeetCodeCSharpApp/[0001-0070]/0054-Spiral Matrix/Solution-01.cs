namespace LeetCodeCSharpApp.SpiralMatrix01;

public class Solution
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        int m = matrix.Length, n = matrix[0].Length;

        var directions = new List<(int, int)> { (0, 1), (1, 0), (0, -1), (-1, 0) };
        var directionIndex = 0;

        var seen = new HashSet<(int, int)>();
        int i = 0, j = 0;
        var result = new List<int>();

        for (var times = 0; times < m * n; times++)
        {
            result.Add(matrix[i][j]);
            seen.Add((i, j));

            var (di, dj) = directions[directionIndex];
            int ni = i + di, nj = j + dj;
            
            if (ni < 0 || ni >= m || nj < 0 || nj >= n || seen.Contains((ni, nj)))
            {
                directionIndex = (directionIndex + 1) % 4;
                (di, dj) = directions[directionIndex];
                ni = i + di;
                nj = j + dj;
            }

            i = ni;
            j = nj;
        }

        return result;
    }
}
