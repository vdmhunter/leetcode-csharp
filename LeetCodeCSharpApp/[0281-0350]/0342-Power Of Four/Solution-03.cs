namespace LeetCodeCSharpApp.PowerOfFour03;

public class Solution
{
    public bool IsPowerOfFour(int n)
    {
        return n > 0 && (n & (n - 1)) == 0 && (n & 0b1010101010101010101010101010101) != 0;
    }
}
