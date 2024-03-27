namespace LeetCodeCSharpApp.SubarrayProductLessThanK01;

public class Solution
{
    public int NumSubarrayProductLessThanK(int[] nums, int k)
    {
        int left = 0, prod = 1, count = 0;

        for (var right = 0; right < nums.Length; right++)
        {
            prod *= nums[right];

            while (prod >= k && left <= right)
            {
                prod /= nums[left];
                left++;
            }

            count += right - left + 1;
        }

        return count;
    }
}
