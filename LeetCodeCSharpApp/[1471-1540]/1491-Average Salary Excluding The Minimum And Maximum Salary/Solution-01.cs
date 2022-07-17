namespace LeetCodeCSharpApp.AverageSalaryExcludingTheMinimumAndMaximumSalary01;

public class Solution
{
    public double Average(int[] salary)
    {
        return salary.Where(s => s != salary.Min() && s != salary.Max()).Average();
    }
}
