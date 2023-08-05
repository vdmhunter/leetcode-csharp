namespace LeetCodeCSharpApp.AccountBalanceAfterRoundedPurchase01;

public class Solution
{
    public int AccountBalanceAfterPurchase(int purchaseAmount)
    {
        return 100 - purchaseAmount / 10 * 10 - (purchaseAmount % 10 >= 5 ? 10 : 0);
    }
}
