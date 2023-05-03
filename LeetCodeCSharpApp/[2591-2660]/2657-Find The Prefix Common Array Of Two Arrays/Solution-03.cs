// ReSharper disable InconsistentNaming

namespace LeetCodeCSharpApp.FindThePrefixCommonArrayOfTwoArrays03;

public class Solution
{
    public int[] FindThePrefixCommonArray(int[] A, int[] B)
    {
        var n = A.Length;
        var current = 0;
        var result = new int[n];
        var seen = new int[n + 1];

        for (var i = 0; i < n; ++i)
        {
            if (++seen[A[i]] == 2)
                current++;

            if (++seen[B[i]] == 2)
                current++;

            result[i] = current;
        }

        return result;
    }
}
