namespace LeetCodeCSharpApp.MaximumScoreOfAGoodSubarray01;

public class Solution
{
    public int MaximumScore(int[] nums, int k)
    {
        int result = nums[k], mini = nums[k], i = k, j = k, n = nums.Length;

        while (i > 0 || j < n - 1)
        {
            if (i == 0)
                ++j;
            else if (j == n - 1)
                --i;
            else if (nums[i - 1] < nums[j + 1])
                ++j;
            else
                --i;

            mini = Math.Min(mini, Math.Min(nums[i], nums[j]));
            result = Math.Max(result, mini * (j - i + 1));
        }

        return result;
    }
}
