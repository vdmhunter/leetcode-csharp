namespace LeetCodeCSharpApp.UniquePaths03;

public class Solution
{
    public int UniquePaths(int m, int n)
    {
        var k = m - 1;
        var result = 1D;

        for (var i = 1; i <= k; i++)
            result = result * (m + n - k + i - 2) / i;

        return (int)result;
    }
}
