namespace LeetCodeCSharpApp.BestTimeToBuyAndSellStockWithCooldown01;

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        var n = prices.Length;

        if (n == 0 || n == 1)
            return 0;

        var sell = new int[n];
        var buy = new int[n];

        buy[0] = -prices[0];
        sell[0] = 0;

        for (var i = 1; i < n; i++)
        {
            sell[i] = Math.Max(sell[i - 1], buy[i - 1] + prices[i]);

            if (i == 1)
                buy[i] = Math.Max(buy[i - 1], -prices[i]);
            else
                buy[i] = Math.Max(buy[i - 1], sell[i - 2] - prices[i]);
        }

        return sell[n - 1];
    }
}
