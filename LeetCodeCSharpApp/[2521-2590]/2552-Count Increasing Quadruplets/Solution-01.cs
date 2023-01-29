namespace LeetCodeCSharpApp.CountIncreasingQuadruplets01;

public class Solution
{
    public long CountQuadruplets(int[] nums)
    {
        var result = 0L;
        var n = nums.Length;
        var left = new int[n, n + 1];
        var right = new int[n, n + 1];

        for (var i = 1; i < n; i++)
        {
            for (var j = 0; j <= n; j++)
                left[i, j] = left[i - 1, j];

            for (var j = nums[i - 1] + 1; j <= n; j++)
                left[i, j]++;
        }

        for (var i = n - 2; i >= 0; i--)
        {
            for (var j = 0; j <= n; j++)
                right[i, j] = right[i + 1, j];

            for (var j = 0; j < nums[i + 1]; j++)
                right[i, j]++;
        }

        for (var i = 0; i < n; i++)
            for (var j = n - 1; j > i; j--)
            {
                if (nums[i] <= nums[j])
                    continue;

                result += left[i, nums[j]] * right[j, nums[i]];
            }

        return result;
    }
}
