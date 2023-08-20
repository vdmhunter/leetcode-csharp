namespace LeetCodeCSharpApp.DetermineTheMinimumSumOfAKAvoidingArray02;

public class Solution
{
    public int MinimumSum(int n, int k)
    {
        return n <= k / 2
            ? (1 + n) * n / 2
            : k / 2 * (k / 2 + 1) / 2 + (k + k + n - k / 2 - 1) * (n - k / 2) / 2;
    }
}
