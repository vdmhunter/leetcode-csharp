// ReSharper disable InconsistentNaming

namespace LeetCodeCSharpApp.FindThePrefixCommonArrayOfTwoArrays02;

public class Solution
{
    public int[] FindThePrefixCommonArray(int[] A, int[] B)
    {
        return A.Select((_, i) => A.Take(i + 1).Intersect(B.Take(i + 1)).Distinct().Count()).ToArray();
    }
}
