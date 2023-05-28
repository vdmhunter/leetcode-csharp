namespace LeetCodeCSharpApp.MinimumCostToCutAStick01;

public class Solution
{
    private int[,] _dp = null!;

    public int MinCost(int n, int[] cuts)
    {
        _dp = new int[cuts.Length, cuts.Length];

        for (var i = 0; i < _dp.GetLength(0); i++)
            for (var j = 0; j < _dp.GetLength(1); j++)
                _dp[i, j] = -1;

        Array.Sort(cuts);

        return Solve(0, n, cuts, 0, cuts.Length - 1);
    }

    private int Solve(int startStick, int endStick, int[] cuts, int left, int right)
    {
        if (left > right)
            return 0;

        if (_dp[left, right] != -1)
            return _dp[left, right];

        var cost = int.MaxValue;

        for (var i = left; i <= right; i++)
        {
            var leftCost = Solve(startStick, cuts[i], cuts, left, i - 1);
            var rightCost = Solve(cuts[i], endStick, cuts, i + 1, right);
            var currCost = endStick - startStick + leftCost + rightCost;
            cost = Math.Min(cost, currCost);
        }

        return _dp[left, right] = cost;
    }
}
