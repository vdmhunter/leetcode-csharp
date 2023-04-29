namespace LeetCodeCSharpApp.KInversePairsArray03;

/// <summary>
/// Best from LeetCode submissions
/// </summary>
public class Solution
{
    public int KInversePairs(int n, int k)
    {
        const int mod = 1000000007;
        var prevNumCount = new long[k + 1];
        var currNumCount = new long[k + 1];
        prevNumCount[0] = 1;

        for (var i = 1; i <= n; i++)
        {
            for (var j = 0; j <= k; j++)
            {
                long sum = 0;
                for (var h = 0; h <= j; h++)
                    if (j - h <= i - 1)
                        sum += prevNumCount[h] % mod;

                currNumCount[j] = sum;
            }

            (prevNumCount, currNumCount) = (currNumCount, prevNumCount);
        }

        return Convert.ToInt32(prevNumCount.Last() % mod);
    }
}
