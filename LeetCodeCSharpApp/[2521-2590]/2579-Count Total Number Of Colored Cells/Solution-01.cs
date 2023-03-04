namespace LeetCodeCSharpApp.CountTotalNumberOfColoredCells01;

public class Solution
{
    public long ColoredCells(int n)
    {
        return 2L * n * (n - 1) + 1;
    }
}
