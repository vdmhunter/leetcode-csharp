namespace LeetCodeCSharpApp.BinaryTreesWithFactors02;

public class Solution
{
    private const long Mod = 1_000_000_007L;

    public int NumFactoredBinaryTrees(int[] arr)
    {
        var result = 0L;
        Array.Sort(arr);
        var dp = new Dictionary<int, long>();

        for (var i = 0; i < arr.Length; ++i)
        {
            dp[arr[i]] = 1L;

            for (var j = 0; j < i; ++j)
                if (arr[i] % arr[j] == 0)
                    dp[arr[i]] = (dp[arr[i]] + dp[arr[j]] * dp.GetValueOrDefault(arr[i] / arr[j], 0L)) % Mod;

            result = (result + dp[arr[i]]) % Mod;
        }

        return (int)result;
    }
}
