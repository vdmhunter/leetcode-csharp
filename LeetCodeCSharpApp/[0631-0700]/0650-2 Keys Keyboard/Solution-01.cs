namespace LeetCodeCSharpApp.TwoKeysKeyboard01;

public class Solution
{
    public int MinSteps(int n)
    {
        if (n == 1)
            return 0;

        var steps = 0;
        var factor = 2;

        while (n > 1)
        {
            while (n % factor == 0)
            {
                steps += factor;
                n /= factor;
            }

            factor++;
        }

        return steps;
    }
}
