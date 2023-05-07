namespace LeetCodeCSharpApp.MakeCostsOfPathsEqualInABinaryTree02;

public class Solution
{
    public int MinIncrements(int n, int[] cost)
    {
        var result = 0;

        for (var i = n / 2; i > 0; i--)
        {
            var r = cost[2 * i - 1];
            var l = cost[2 * i];
            result += Math.Abs(l - r);
            cost[i - 1] += Math.Max(l, r);
        }

        return result;
    }
}
