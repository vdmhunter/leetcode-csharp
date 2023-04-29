namespace LeetCodeCSharpApp.MinimumAdditionToMakeIntegerBeautiful01;

public class Solution
{
    public long MakeIntegerBeautiful(long n, int target)
    {
        var n0 = n;
        var b = 1L;

        while (Sum(n) > target)
        {
            n = n / 10 + 1;
            b *= 10;
        }

        return n * b - n0;
    }

    private static int Sum(long n)
    {
        var result = 0;

        while (n > 0)
        {
            result += (int)(n % 10);
            n /= 10;
        }

        return result;
    }
}
