namespace LeetCodeCSharpApp.CountAllPossibleRoutes01;

public class Solution
{
    private const int Mod = 1_000_000_007;
    private readonly int[,] _dp = new int[101, 201];

    public int CountRoutes(int[] locations, int start, int finish, int fuel)
    {
        if (_dp[start, fuel] != 0)
            return _dp[start, fuel] - 1;

        _dp[start, fuel] = 1 + (start == finish ? 1 : 0);

        for (var j = 0; j < locations.Length; ++j)
            if (start != j && fuel >= Math.Abs(locations[start] - locations[j]))
                _dp[start, fuel] =
                    (_dp[start, fuel] + CountRoutes(locations, j, finish,
                        fuel - Math.Abs(locations[start] - locations[j]))) % Mod;

        return _dp[start, fuel] - 1;
    }
}
