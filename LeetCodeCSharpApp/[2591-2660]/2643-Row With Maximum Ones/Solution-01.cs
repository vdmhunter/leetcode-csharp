namespace LeetCodeCSharpApp.RowWithMaximumOnes01;

public class Solution
{
    public int[] RowAndMaximumOnes(int[][] mat)
    {
        var maxCount = 0;
        var maxRowIndex = 0;

        for (var i = 0; i < mat.Length; i++)
        {
            var count = 0;

            for (var j = 0; j < mat[i].Length; j++)
                if (mat[i][j] == 1)
                    count++;

            if (count <= maxCount)
                continue;

            maxCount = count;
            maxRowIndex = i;
        }

        return new[] { maxRowIndex, maxCount };
    }
}
