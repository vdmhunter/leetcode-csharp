namespace LeetCodeCSharpApp.LongestSubarrayOf1sAfterDeletingOneElement01;

public class Solution
{
    public int LongestSubarray(int[] nums)
    {
        int i = 0, j, k = 1;

        for (j = 0; j < nums.Length; j++)
        {
            if (nums[j] == 0)
                k--;

            if (k < 0 && nums[i++] == 0)
                k++;
        }

        return j - i - 1;
    }
}
