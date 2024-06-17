namespace LeetCodeCSharpApp.SumOfSquareNumbers01;

public class Solution
{
    public bool JudgeSquareSum(int c)
    {
        for (var divisor = 2; divisor * divisor <= c; divisor++)
        {
            if (c % divisor != 0)
                continue;

            var exponentCount = 0;

            while (c % divisor == 0)
            {
                exponentCount++;
                c /= divisor;
            }

            if (divisor % 4 == 3 && exponentCount % 2 != 0)
                return false;
        }

        return c % 4 != 3;
    }
}
