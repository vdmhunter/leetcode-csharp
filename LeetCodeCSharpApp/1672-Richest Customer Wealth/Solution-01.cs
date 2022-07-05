namespace LeetCodeCSharpApp.RichestCustomerWealth01;

public class Solution
{
    public int MaximumWealth(int[][] accounts)
    {
        return accounts.Select(a => a.Sum()).Max();
    }
}
