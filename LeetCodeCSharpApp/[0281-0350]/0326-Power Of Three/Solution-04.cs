namespace LeetCodeCSharpApp.PowerOfThree04;

public class Solution
{
    public bool IsPowerOfThree(int n) => Math.Log10(n) / Math.Log10(3) % 1 == 0;
}
