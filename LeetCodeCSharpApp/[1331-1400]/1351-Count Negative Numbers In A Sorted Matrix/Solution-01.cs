namespace LeetCodeCSharpApp.CountNegativeNumbersInASortedMatrix01;

public class Solution
{
    public int CountNegatives(int[][] grid)
    {
        return grid.Sum(row => row.Count(num => num < 0));
    }
}
