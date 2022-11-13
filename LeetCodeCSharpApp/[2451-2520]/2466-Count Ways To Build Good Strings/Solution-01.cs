namespace LeetCodeCSharpApp.CountWaysToBuildGoodStrings01;

public class Solution
{
    private const int M = 1000000007;

    public int CountGoodStrings(int low, int high, int zero, int one)
    {
        var result = 0;
        var dp = new int[high + 1];
        dp[0] = 1;

        for (var i = 1; i <= high; i++)
        {
            if (i >= zero)
                dp[i] = (dp[i] + dp[i - zero]) % M;

            if (i >= one)
                dp[i] = (dp[i] + dp[i - one]) % M;

            if (i >= low)
                result = (result + dp[i]) % M;
        }

        return result;
    }
}
