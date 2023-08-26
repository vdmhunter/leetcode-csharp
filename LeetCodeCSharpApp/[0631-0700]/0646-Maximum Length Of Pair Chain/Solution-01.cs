namespace LeetCodeCSharpApp.MaximumLengthOfPairChain01;

public class Solution
{
    public int FindLongestChain(int[][] pairs)
    {
        Array.Sort(pairs, (a, b) => a[1] - b[1]);

        int tail = int.MinValue, result = 0;

        foreach (var pair in pairs)
        {
            if (pair[0] <= tail)
                continue;

            result++;
            tail = pair[1];
        }

        return result;
    }
}
