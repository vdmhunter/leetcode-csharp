// ReSharper disable IdentifierTypo

namespace LeetCodeCSharpApp.SubArraysWithKDifferentIntegers01;

public class Solution
{
    public int SubarraysWithKDistinct(int[] nums, int k)
    {
        return UpToKDistinct(nums, k) - UpToKDistinct(nums, k - 1);
    }

    private static int UpToKDistinct(int[] nums, int k)
    {
        var result = 0;
        var count = new int[nums.Length + 1];

        for (int l = 0, r = 0; r < nums.Length; r++)
        {
            if (count[nums[r]] == 0)
                k--;

            count[nums[r]]++;

            while (k < 0)
                if (--count[nums[l++]] == 0)
                    k++;

            result += r - l + 1;
        }

        return result;
    }
}
