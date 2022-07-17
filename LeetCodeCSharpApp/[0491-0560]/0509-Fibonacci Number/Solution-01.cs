namespace LeetCodeCSharpApp.FibonacciNumber01;

public class Solution
{
    public int Fib(int n)
    {
        if (n is 0 or 1)
            return n;

        return Fib(n - 1) + Fib(n - 2);
    }
}
