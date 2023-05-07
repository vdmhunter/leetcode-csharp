namespace LeetCodeCSharpApp.MakeCostsOfPathsEqualInABinaryTree01;

public class Solution
{
    public int MinIncrements(int n, int[] cost)
    {
        var result = 0;
        var sum = new int[n];

        for (var i = n - 1; i >= 0; i--)
        {
            sum[i] = cost[i];

            if (i * 2 + 1 < n)
                sum[i] += Math.Max(sum[i * 2 + 1], sum[i * 2 + 2]);
        }

        for (var i = 0; i < n; i++)
            if (i * 2 + 1 < n)
                result += Math.Abs(sum[i * 2 + 1] - sum[i * 2 + 2]);

        return result;
    }
}
