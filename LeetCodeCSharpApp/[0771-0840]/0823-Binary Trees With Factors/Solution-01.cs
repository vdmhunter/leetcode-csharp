namespace LeetCodeCSharpApp.BinaryTreesWithFactors01;

public class Solution
{
    public int NumFactoredBinaryTrees(int[] nums)
    {
        Array.Sort(nums);
        var numToIndex = nums.Select((x, i) => (x, i)).ToDictionary(p => p.x, p => p.i);
        var dp = new int[nums.Length];
        dp[0] = 1;

        for (var i = 1; i < nums.Length; i++)
        {
            dp[i] = 1;
            
            for (var j = 0; j < i; j++)
                if (nums[i] % nums[j] == 0 && numToIndex.TryGetValue(nums[i] / nums[j], out var index))
                    dp[i] = Add(dp[i], Mul(dp[j], dp[index]));
        }

        return dp.Aggregate(Add);
    }

    private const int Max = 1000000007;

    private static int Add(int x, int y) => (x + y) % Max;

    private static int Mul(int x, int y) => (int)(x * (long)y % Max);
}
