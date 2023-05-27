namespace LeetCodeCSharpApp.BuyTwoChocolates02;

public class Solution
{
    public int BuyChoco(int[] prices, int money)
    {
        var minPrices = prices.OrderBy(p => p).Take(2).ToArray();

        return money < minPrices.Sum() ? money : money - minPrices.Sum();
    }
}
