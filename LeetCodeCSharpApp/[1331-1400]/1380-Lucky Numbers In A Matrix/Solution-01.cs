namespace LeetCodeCSharpApp.LuckyNumbersInAMatrix01;

public class Solution
{
    public IList<int> LuckyNumbers(int[][] matrix)
    {
        int minRowMax = matrix.Select(row => row.Min()).Max();
        int maxColMin = matrix[0].Select((_, index) => matrix.Select(row => row[index]).Max()).Min();

        return minRowMax == maxColMin ? new List<int> { minRowMax } : [];
    }
}
