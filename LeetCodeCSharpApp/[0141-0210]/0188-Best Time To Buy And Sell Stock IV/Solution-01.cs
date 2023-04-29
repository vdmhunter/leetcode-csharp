namespace LeetCodeCSharpApp.BestTimeToBuyAndSellStockIV01;

// Easy to understand explanation for the above solution:
// 
// dp[i][j] = maximum profit from at most i transactions using prices[0..j]
// A transaction is defined as one buy + sell.
// 
// Now on day j, we have two options
// 
// Do nothing (or buy) which doesn't change the acquired profit : dp[i][j] = dp[i][j-1]
// 
// Sell the stock: In order to sell the stock, you must've bought it on a day t=[0..j-1].
// Maximum profit that can be attained is t:0->j-1 max(prices[j]-prices[t]+dp[i-1][t-1])
// where prices[j]-prices[t] is the profit from buying on day t and selling on day j.
// dp[i-1][t-1] is the maximum profit that can be made with at most i-1 transactions with prices prices[0..t-1].
// 
// Time complexity of this approach is O(n2k).
// 
// In order to reduce it to O(nk), we must find t:0->j-1 max(prices[j]-prices[t]+dp[i-1][t-1])
// this expression in constant time. If you see carefully,
// 
// t:0->j-1 max(prices[j]-prices[t]+dp[i-1][t-1]) is same as
// 
// prices[j] + t:0->j-1 max(dp[i-1][t-1]-prices[t])
// 
// Second part of the above expression maxTemp = t:0->j-1 max(dp[i-1][t-1]-prices[t])
// can be included in the dp loop by keeping track of the maximum value till j-1.
// 
// Base case:
// 
// dp[0][j] = 0; dp[i][0] = 0
// 
// DP loop:
// 
// for i : 1 -> k
//     maxTemp = -prices[0];
//     for j : 1 -> n-1
//         dp[i][j] = max(dp[i][j-1], prices[j]+maxTemp);
//         maxTemp = max(maxTemp, dp[i-1][j-1]-prices[j]);
// return dp[k][n-1];

public class Solution
{
    public int MaxProfit(int k, int[] prices)
    {
        var len = prices.Length;

        if (k >= len / 2)
            return QuickSolve(prices);

        var t = new int[k + 1][];
        t[0] = new int[len];

        for (var i = 1; i <= k; i++)
        {
            t[i] = new int[len];
            var tmpMax = -prices[0];

            for (var j = 1; j < len; j++)
            {
                t[i][j] = Math.Max(t[i][j - 1], prices[j] + tmpMax);
                tmpMax = Math.Max(tmpMax, t[i - 1][j - 1] - prices[j]);
            }
        }

        return t[k][len - 1];
    }

    private static int QuickSolve(IReadOnlyList<int> prices)
    {
        int len = prices.Count, profit = 0;

        for (var i = 1; i < len; i++)
            if (prices[i] > prices[i - 1])
                profit += prices[i] - prices[i - 1];

        return profit;
    }
}
