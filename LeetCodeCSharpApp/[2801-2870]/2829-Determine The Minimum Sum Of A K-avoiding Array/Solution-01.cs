namespace LeetCodeCSharpApp.DetermineTheMinimumSumOfAKAvoidingArray01;

public class Solution
{
    public int MinimumSum(int n, int k)
    {
        var last = Math.Max(n, k - 1);

        return Enumerable.Range(1, n).Sum(i =>
        {
            if (k - i > i && k - i <= n)
                return i + ++last - (k - i);

            return i;
        });
    }
}
