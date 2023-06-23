namespace LeetCodeCSharpApp.BestTimeToBuyAndSellStockWithTransactionFee01;

public class Solution
{
    public int MaxProfit(int[] prices, int fee)
    {
        var len = prices.Length;
        var buy = new int[len];
        var sell = new int[len];

        buy[0] = -prices[0];

        for (var i = 1; i < len; i++)
        {
            buy[i] = Math.Max(buy[i - 1], sell[i - 1] - prices[i]);
            sell[i] = Math.Max(sell[i - 1], buy[i - 1] + prices[i] - fee);
        }

        return sell[len - 1];
    }
}
