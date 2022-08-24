namespace LeetCodeCSharpApp.PowerOfThree01;

public class Solution
{
    public bool IsPowerOfThree(int n)
    {
        if (n <= 1)
            return n == 1;

        while (n % 3 == 0)
            n /= 3;

        return n == 1;
    }
}
