namespace LeetCodeCSharpApp.NumberOfDiceRollsWithTargetSum01;

public class Solution
{
    private const int Mod = 1_000_000_007;

    public int NumRollsToTarget(int n, int k, int target)
    {
        var dp = new long[target + 1];
        dp[0] = 1;
        
        for (var x = 1; x <= n; x++)
            for (var y = target; y >= 0; y--)
            {
                dp[y] = 0;
                
                for (var z = 1; z <= k; z++)
                    if (y >= z)
                        dp[y] = (dp[y] + dp[y - z]) % Mod;
                    else
                        break;
            }

        return (int)dp[target];
    }
}
