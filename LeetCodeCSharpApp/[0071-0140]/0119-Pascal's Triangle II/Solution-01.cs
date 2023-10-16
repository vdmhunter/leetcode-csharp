namespace LeetCodeCSharpApp.PascalsTriangleII01;

public class Solution
{
    public IList<int> GetRow(int rowIndex)
    {
        var result = new List<int> { 1 };
        var prev = 1L;

        for (var k = 1; k <= rowIndex; k++)
        {
            var next = prev * (rowIndex - k + 1) / k;
            result.Add((int)next);
            prev = next;
        }

        return result;
    }
}
