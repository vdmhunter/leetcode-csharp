// ReSharper disable InconsistentNaming

namespace LeetCodeCSharpApp.MinimumImpossibleOR01;

public class Solution
{
    public int MinImpossibleOR(int[] nums)
    {
        var res = 1;

        while (nums.Contains(res))
            res <<= 1;

        return res;
    }
}
