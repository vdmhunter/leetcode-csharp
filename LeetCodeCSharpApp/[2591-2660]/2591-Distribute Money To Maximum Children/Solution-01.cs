namespace LeetCodeCSharpApp.DistributeMoneyToMaximumChildren01;

public class Solution
{
    public int DistMoney(int money, int children)
    {
        return money == 8 * children
            ? children
            : money > 8 * children - 8 && money != 8 * children - 4
                ? children - 1
                : money < children
                    ? -1
                    : Math.Min(children - 2, (money - children) / 7);
    }
}
