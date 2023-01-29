namespace LeetCodeCSharpApp.PutMarblesInBags01;

public class Solution
{
    public long PutMarbles(int[] weights, int k)
    {
        var n = weights.Length - 1;
        var tmp = new long[n];
        var result = 0L;

        for (var i = 0; i < tmp.Length; i++)
            tmp[i] = weights[i] + weights[i + 1];

        Array.Sort(tmp);

        for (var i = 0; i < k - 1; i++)
            result += tmp[n - 1 - i] - tmp[i];

        return result;
    }
}
