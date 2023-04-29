namespace LeetCodeCSharpApp.NumberOfCommonFactors01;

public class Solution
{
    public int CommonFactors(int a, int b)
    {
        var n = Gcd(a, b);
        var result = 0;

        for (var i = 1; i <= Math.Sqrt(n); i++)
        {
            if (n % i != 0)
                continue;

            if (n / i == i)
                result += 1;
            else
                result += 2;
        }

        return result;
    }

    private static int Gcd(int a, int b)
    {
        return b == 0 ? a : Gcd(b, a % b);
    }
}
