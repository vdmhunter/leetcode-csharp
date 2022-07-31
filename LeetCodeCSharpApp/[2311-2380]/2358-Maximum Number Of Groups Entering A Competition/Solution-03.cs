namespace LeetCodeCSharpApp.MaximumNumberOfGroupsEnteringACompetition03;

public class Solution
{
    public int MaximumGroups(int[] grades)
    {
        var n = grades.Length;
        var x = (int)(Math.Sqrt(8 * n + 1) - 1) / 2;
        
        return x;
    }
}
