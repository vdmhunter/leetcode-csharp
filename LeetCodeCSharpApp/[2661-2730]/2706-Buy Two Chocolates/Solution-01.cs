namespace LeetCodeCSharpApp.BuyTwoChocolates01;

public class Solution
{
    public int BuyChoco(int[] prices, int money)
    {
        var minPrice1 = int.MaxValue;
        var minPrice2 = int.MaxValue;

        foreach (var p in prices)
            if (p < minPrice1)
            {
                minPrice2 = minPrice1;
                minPrice1 = p;
            }
            else if (p < minPrice2)
                minPrice2 = p;

        if (minPrice1 + minPrice2 <= money)
            return money - (minPrice1 + minPrice2);

        return money;
    }
}
