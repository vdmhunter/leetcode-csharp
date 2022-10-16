namespace LeetCodeCSharpApp.RangeProductQueriesOfPowers01;

public class Solution
{
    private const int Mod = 1_000_000_007;

    public int[] ProductQueries(int n, int[][] queries)
    {
        var result = new int[queries.Length];
        var powers = new List<int>();

        for (var currentPow = 1; currentPow != 0; currentPow <<= 1)
            if ((currentPow & n) != 0)
                powers.Add(currentPow);

        for (var i = 0; i < queries.Length; i++)
        {
            var r = 1L;

            for (var j = queries[i][0]; j <= queries[i][1]; j++)
                r = r * powers[j] % Mod;

            result[i] = (int)r;
        }

        return result;
    }
}
