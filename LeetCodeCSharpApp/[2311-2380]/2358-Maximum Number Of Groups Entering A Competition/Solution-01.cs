namespace LeetCodeCSharpApp.MaximumNumberOfGroupsEnteringACompetition01;

public class Solution
{
    public int MaximumGroups(int[] grades)
    {
        int result = 1, size = grades.Length;

        while (result < size)
        {
            size -= result;

            if (result < size)
                result++;
        }

        return result;
    }
}
