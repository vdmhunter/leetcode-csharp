namespace LeetCodeCSharpApp.KInversePairsArray01;

/// <summary>
/// Using Recursion with Memoization (TLE)
/// </summary>
public class Solution
{
    private readonly int[,] _memo = new int[1001, 1001];

    public int KInversePairs(int n, int k)
    {
        if (n == 0)
            return 0;

        if (k == 0)
            return 1;

        if (_memo[n, k] != 0)
            return _memo[n, k];

        var inv = 0;

        for (var i = 0; i <= Math.Min(k, n - 1); i++)
            inv = (inv + KInversePairs(n - 1, k - i)) % 1000000007;

        _memo[n, k] = inv;

        return inv;
    }
}
