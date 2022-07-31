namespace LeetCodeCSharpApp.MaximumNumberOfGroupsEnteringACompetition02;

public class Solution
{
    public int MaximumGroups(int[] grades)
    {
        int s = 0, e = 1000;
        var result = 0;

        while (s <= e)
        {
            var mid = s + (e - s) / 2;
            
            if (mid * (mid + 1) / 2 <= grades.Length)
            {
                result = mid;
                s = mid + 1;
            }
            else
                e = mid - 1;
        }

        return result;
    }
}
