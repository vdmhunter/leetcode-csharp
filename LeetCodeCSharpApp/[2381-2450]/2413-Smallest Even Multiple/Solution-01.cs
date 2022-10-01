namespace LeetCodeCSharpApp.SmallestEvenMultiple01;

public class Solution
{
    public int SmallestEvenMultiple(int n)
    {
        return 2 * n / Gcd(2, n);
    }

    private static int Gcd(int a, int b)
    {
        return b == 0 ? a : Gcd(b, a % b);
    }
}
