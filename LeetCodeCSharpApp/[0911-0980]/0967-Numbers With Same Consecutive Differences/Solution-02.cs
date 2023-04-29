namespace LeetCodeCSharpApp.NumbersWithSameConsecutiveDifferences02;

/// <summary>
/// DFS
/// </summary>
public class Solution
{
    // ReSharper disable once IdentifierTypo
    public int[] NumsSameConsecDiff(int n, int k)
    {
        if (n == 1)
            return new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        var list = new List<int>();

        for (var i = 1; i <= 9; i++)
            Dfs(list, n - 1, k, i);

        return list.ToArray();
    }

    private void Dfs(List<int> list, int n, int k, int num)
    {
        if (n <= 0)
        {
            list.Add(num);

            return;
        }

        var lastDigit = num % 10;

        if (lastDigit + k <= 9)
            Dfs(list, n - 1, k, num * 10 + lastDigit + k);

        if (lastDigit - k >= 0 && k != 0)
            Dfs(list, n - 1, k, num * 10 + lastDigit - k);
    }
}
