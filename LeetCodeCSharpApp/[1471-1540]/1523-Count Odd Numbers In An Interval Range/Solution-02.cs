namespace LeetCodeCSharpApp.CountOddNumbersInAnIntervalRange02;

public class Solution
{
    public int CountOdds(int low, int high)
    {
        return ((high + 1) >> 1) - (low >> 1);
    }
}