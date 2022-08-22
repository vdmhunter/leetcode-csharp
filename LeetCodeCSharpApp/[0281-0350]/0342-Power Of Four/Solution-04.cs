namespace LeetCodeCSharpApp.PowerOfFour04;

public class Solution
{
    public bool IsPowerOfFour(int n)
    {
        return Math.Log(n, 4) % 1 == 0;
    }
}
