namespace LeetCodeCSharpApp.FairDistributionOfCookies02;

public class Solution
{
    private int _result = int.MaxValue;

    public int DistributeCookies(int[] cookies, int k)
    {
        var distribution = new int[k];
        Backtrack(distribution, cookies, k, 0);

        return _result;
    }

    private int Backtrack(int[] distribution, int[] cookies, int k, int cookieIndex)
    {
        if (cookieIndex == cookies.Length)
            return distribution.Prepend(int.MinValue).Max();

        // try to distribute cookies to every child
        for (var i = 0; i < k; i++)
        {
            // there not enough cookies left for the remaining kids
            if (k - i - 1 > cookies.Length - cookieIndex - 1)
                continue;

            distribution[i] += cookies[cookieIndex];
            _result = Math.Min(_result, Backtrack(distribution, cookies, k, cookieIndex + 1));
            distribution[i] -= cookies[cookieIndex];
        }

        return _result;
    }
}
