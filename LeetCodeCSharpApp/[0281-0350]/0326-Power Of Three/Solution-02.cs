namespace LeetCodeCSharpApp.PowerOfThree02;

public class Solution
{
    public bool IsPowerOfThree(int n) => n > 0 && (n == 1 || (n % 3 == 0 && IsPowerOfThree(n / 3)));
}
