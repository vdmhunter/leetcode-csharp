namespace LeetCodeCSharpApp.PowerOfFour01;

public class Solution
{
    public bool IsPowerOfFour(int n)
    {
        return n == 1 || (n != 0 && n % 4 == 0 && IsPowerOfFour(n / 4));
    }
}
