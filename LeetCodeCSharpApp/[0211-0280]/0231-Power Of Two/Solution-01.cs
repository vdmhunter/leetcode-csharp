namespace LeetCodeCSharpApp.PowerOfTwo01;

public class Solution
{
    public bool IsPowerOfTwo(int n)
    {
        if (n == 0)
            return false;

        var x = (long)n;

        return (x & -x) == x;
    }
}
