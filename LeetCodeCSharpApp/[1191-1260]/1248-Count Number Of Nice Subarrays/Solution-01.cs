namespace LeetCodeCSharpApp.CountNumberOfNiceSubarrays01;

public class Solution
{
    public int NumberOfSubarrays(int[] nums, int k)
    {
        int result = 0, count = 0;

        for (int l = 0, r = 0; r < nums.Length; r++)
        {
            if (nums[r] % 2 == 1)
            {
                k--;
                count = 0;
            }

            while (k == 0)
            {
                count++;
                k += nums[l++] % 2;
            }

            result += count;
        }

        return result;
    }
}
