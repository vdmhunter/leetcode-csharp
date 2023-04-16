namespace LeetCodeCSharpApp.FindTheMaximumDivisibilityScore01;

public class Solution
{
    public int MaxDivScore(int[] nums, int[] divisors)
    {
        var maxScore = 0;
        var maxDivisor = int.MaxValue;

        foreach (var divisor in divisors)
        {
            var score = nums.Count(num => num % divisor == 0);

            if (score > maxScore)
            {
                maxScore = score;
                maxDivisor = divisor;
            }
            else if (score == maxScore)
                maxDivisor = Math.Min(maxDivisor, divisor);
        }

        return maxDivisor;
    }
}
