namespace LeetCodeCSharpApp.CalculateMoneyInLeetcodeBank;

public class Solution
{
    public int TotalMoney(int n)
    {
        return Enumerable.Range(1, n).Select((val, index) => (val % 7 == 0 ? 7 : val % 7) + index / 7).Sum();
    }
}
