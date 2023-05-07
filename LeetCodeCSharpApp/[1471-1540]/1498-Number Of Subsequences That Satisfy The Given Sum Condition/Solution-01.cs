// ReSharper disable IdentifierTypo

namespace LeetCodeCSharpApp.NumberOfSubsequencesThatSatisfyTheGivenSumCondition01;

public class Solution
{
    private const int Mod = 1_000_000_007;

    public int NumSubseq(int[] nums, int target)
    {
        int result = 0, l = 0, r = nums.Length - 1;
        var pre = new List<int> { 1 };

        for (var i = 1; i <= nums.Length; i++)
            pre.Add((pre[i - 1] << 1) % Mod);

        Array.Sort(nums);

        while (l <= r)
            if (nums[l] + nums[r] > target)
                r--;
            else
                result = (result + pre[r - l++]) % Mod;

        return result;
    }
}
