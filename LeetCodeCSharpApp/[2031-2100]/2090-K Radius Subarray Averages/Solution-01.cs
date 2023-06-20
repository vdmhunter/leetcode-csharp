namespace LeetCodeCSharpApp.KRadiusSubarrayAverages01;

public class Solution
{
    public int[] GetAverages(int[] nums, int k)
    {
        var result = new int[nums.Length];

        for (var i = 0; i < nums.Length; i++)
            result[i] = -1;

        var sum = 0L;
        var d = k * 2L + 1L;

        for (var i = 0; i < nums.Length; i++)
        {
            sum += nums[i];

            if (i + 1 < d)
                continue;

            if (i >= d)
                sum -= nums[i - (int)d];

            result[i - (int)d / 2] = (int)(sum / d);
        }

        return result;
    }
}
