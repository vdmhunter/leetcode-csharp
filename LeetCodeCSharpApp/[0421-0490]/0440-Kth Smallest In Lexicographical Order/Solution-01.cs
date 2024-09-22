namespace LeetCodeCSharpApp.KthSmallestInLexicographicalOrder01;

public class Solution
{
    public int FindKthNumber(int n, int k)
    {
        var result = 1;
        k--;

        while (k > 0)
        {
            var count = 0L;

            for (long first = result, last = result + 1; first <= n; first *= 10, last *= 10)
            {
                count += Math.Min(n + 1, last) - first;
            }

            if (k < count)
            {
                result *= 10;
                k--;
            }
            else
            {
                result++;
                k -= (int)count;
            }
        }

        return result;
    }
}
