namespace LeetCodeCSharpApp.LongestAlternatingSubarray01;

public class Solution
{
    public int AlternatingSubarray(int[] nums)
    {
        var maxLen = 1;
        var currLen = 1;

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1] + (currLen % 2 == 1 ? 1 : -1))
            {
                currLen++;
            }
            else
            {
                maxLen = Math.Max(maxLen, currLen);
                currLen = nums[i] == nums[i - 1] + 1 ? 2 : 1;
            }
        }

        maxLen = Math.Max(maxLen, currLen);

        return maxLen > 1 ? maxLen : -1;
    }
}
