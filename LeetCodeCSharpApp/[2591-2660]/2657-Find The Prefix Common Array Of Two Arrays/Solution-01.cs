// ReSharper disable InconsistentNaming

namespace LeetCodeCSharpApp.FindThePrefixCommonArrayOfTwoArrays01;

public class Solution
{
    public int[] FindThePrefixCommonArray(int[] A, int[] B)
    {
        var n = A.Length;
        var result = new int[n];
        var seenA = new bool[n + 1];
        var seenB = new bool[n + 1];

        for (var i = 0; i < n; i++)
        {
            seenA[A[i]] = true;
            seenB[B[i]] = true;

            for (var j = 1; j <= n; j++)
                if (seenA[j] && seenB[j])
                    result[i]++;
        }

        return result;
    }
}
