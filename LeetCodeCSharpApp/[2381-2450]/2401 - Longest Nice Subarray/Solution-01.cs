namespace LeetCodeCSharpApp.LongestNiceSubarray01;

public class Solution
{
    public int LongestNiceSubarray(int[] nums)
    {
        int used = 0, j = 0, result = 0;
        
        for (var i = 0; i < nums.Length; ++i)
        {
            while ((used & nums[i]) != 0)
                used ^= nums[j++];
            
            used |= nums[i];
            result = Math.Max(result, i - j + 1);
        }

        return result;
    }
}
