namespace LeetCodeCSharpApp.AverageValueOfEvenNumbersThatAreDivisibleByThree02;

public class Solution
{
    public int AverageValue(int[] nums)
    {
        return (int)nums
            .Where(item => item % 6 == 0)
            .DefaultIfEmpty()
            .Average();
    }
}
