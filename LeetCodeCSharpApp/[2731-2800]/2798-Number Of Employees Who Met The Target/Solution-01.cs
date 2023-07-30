namespace LeetCodeCSharpApp.NumberOfEmployeesWhoMetTheTarget01;

public class Solution
{
    public int NumberOfEmployeesWhoMetTarget(int[] hours, int target)
    {
        return hours.Count(i => i >= target);
    }
}
