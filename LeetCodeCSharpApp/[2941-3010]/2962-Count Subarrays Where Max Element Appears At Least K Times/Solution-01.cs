// ReSharper disable IdentifierTypo

namespace LeetCodeCSharpApp.CountSubArraysWhereMaxElementAppearsAtLeastKTimes01;

public class Solution
{
    public long CountSubarrays(int[] nums, int k)
    {
        int max = nums.Max();
        int n = nums.Length;
        int cur = 0, i = 0;
        var result = 0L;

        for (var j = 0; j < n; j++)
        {
            cur += nums[j] == max ? 1 : 0;

            while (cur >= k)
                cur -= nums[i++] == max ? 1 : 0;

            result += i;
        }

        return result;
    }
}
