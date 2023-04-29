namespace LeetCodeCSharpApp.PascalsTriangle01;

public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        var result = new List<IList<int>>(numRows);

        for (var n = 0; n < numRows; n++)
        {
            var row = new int[n + 1];
            row[0] = 1;
            row[n] = 1;

            if (n > 1)
                for (var i = 1; i <= n - 1; i++)
                    row[i] = result[n - 1][i - 1] + result[n - 1][i];

            result.Add(row.ToList());
        }

        return result;
    }
}
