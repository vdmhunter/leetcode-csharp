namespace LeetCodeCSharpApp.MaximizeTheProfitAsTheSalesman01;

public class Solution
{
    public int MaximizeTheProfit(int n, IList<IList<int>> offers)
    {
        var dp = new int[n + 1];
        var dailyOffers = new List<List<List<int>>>();

        for (var i = 0; i < n; i++)
            dailyOffers.Add(new List<List<int>>());

        foreach (var o in offers)
        {
            var offer = (List<int>)o;
            dailyOffers[offer[1]].Add(offer);
        }

        for (var i = 1; i <= n; i++)
        {
            dp[i] = dp[i - 1];

            foreach (var o in dailyOffers[i - 1])
                dp[i] = Math.Max(dp[i], dp[o[0]] + o[2]);
        }

        return dp[n];
    }
}
