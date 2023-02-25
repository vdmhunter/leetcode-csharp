namespace LeetCodeCSharpApp.BestTimeToBuyAndSellStock01;

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        var minPrice = int.MaxValue;
        var maxProfit = 0;

        foreach (var p in prices)
        {
            if (p < minPrice)
                minPrice = p;
            else if (p - minPrice > maxProfit)
                maxProfit = p - minPrice;
        }

        return maxProfit;
    }
}
