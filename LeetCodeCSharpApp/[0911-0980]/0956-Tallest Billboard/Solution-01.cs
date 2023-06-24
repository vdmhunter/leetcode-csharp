namespace LeetCodeCSharpApp.TallestBillboard01;

public class Solution
{
    public int TallestBillboard(int[] rods)
    {
        Dictionary<int, int> dp = new() { [0] = 0 };

        foreach (var x in rods)
        {
            var cur = new Dictionary<int, int>(dp);

            foreach (var d in cur.Keys)
            {
                if (!dp.ContainsKey(d + x))
                    dp[d + x] = 0;

                dp[d + x] = Math.Max(cur[d], dp[d + x]);

                if (!dp.ContainsKey(Math.Abs(d - x)))
                    dp[Math.Abs(d - x)] = 0;

                dp[Math.Abs(d - x)] = Math.Max(cur[d] + Math.Min(d, x), dp[Math.Abs(d - x)]);
            }
        }

        return dp[0];
    }
}
