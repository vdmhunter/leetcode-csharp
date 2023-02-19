namespace LeetCodeCSharpApp.CountTheNumberOfSquareFreeSubsets01;

public class Solution
{
    private const int Mod = 1_000_000_007;
    private readonly int[,] _dp = new int[1001, 1024];
    private readonly int[] _f =
    {
        -1, 0, 1, 2, -1, 4, 3, 8, -1, -1, 5, 16, -1, 32, 9, 6, -1, 64, -1, 128, -1, 10, 17, 256, -1, -1, 33, -1, -1,
        512, 7
    };

    public int SquareFreeSubsets(int[] nums)
    {
        var list = new List<int>(nums);

        return Dfs(0, 0, list);
    }

    private int Dfs(int i, int mask, List<int> nums)
    {
        if (i >= nums.Count)
            return 0;

        if (_dp[i, mask] != 0)
            return _dp[i, mask] - 1;

        _dp[i, mask] = (1 + Dfs(i + 1, mask, nums)) % Mod;

        if (_f[nums[i]] != -1 && (mask & _f[nums[i]]) == 0)
            _dp[i, mask] = (_dp[i, mask] + 1 + Dfs(i + 1, mask + _f[nums[i]], nums)) % Mod;

        return _dp[i, mask] - 1;
    }
}
