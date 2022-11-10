namespace LeetCodeCSharpApp.AverageValueOfEvenNumbersThatAreDivisibleByThree01;

public class Solution
{
    public int AverageValue(int[] nums)
    {
        int sum = 0, count = 0;

        foreach (var num in nums.Where(n => n % 3 == 0 && n % 2 == 0))
        {
            sum += num;
            count++;
        }

        return count == 0 ? 0 : (int)Math.Round(decimal.Divide(sum, count), MidpointRounding.ToZero);
    }
}
