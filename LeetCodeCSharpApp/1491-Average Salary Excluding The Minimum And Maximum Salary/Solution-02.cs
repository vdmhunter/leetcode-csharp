namespace LeetCodeCSharpApp.AverageSalaryExcludingTheMinimumAndMaximumSalary02;

public class Solution
{
    public double Average(int[] salary)
    {
        var max = salary[0];
        var min = salary[0];
        long sum = salary[0];

        for (var i = 1; i < salary.Length; i++)
        {
            max = Math.Max(max, salary[i]);
            min = Math.Min(min, salary[i]);
            sum += salary[i];
        }

        return (double)(sum - max - min) / (salary.Length - 2);
    }
}
