namespace LeetCodeCSharpApp.LongestSubarrayWithMaximumBitwiseAND01;

public class Solution
{
    public int LongestSubarray(int[] nums)
    {
        int subArrLen = 0, result = 0;

        var maxNum = nums.Max();

        foreach (var n in nums)
        {
            if (n == maxNum)
                subArrLen++;
            else
                subArrLen = 0; // As a subarray is a contiguous sequence of elements, we start the count again.
            
            result = Math.Max(result, subArrLen); // Check and store the current length if it is larger.
        }
        
        return result;
    }
}
