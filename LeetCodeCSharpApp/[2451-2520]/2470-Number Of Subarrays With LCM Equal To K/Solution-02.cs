namespace LeetCodeCSharpApp.NumberOfSubarraysWithLCMEqualToK02;

public class Solution
{
    public int SubarrayLCM(int[] nums, int k)
    {
        var result = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            var lcm = 1;
            
            for (var j = i; j < nums.Length && k % nums[j] == 0; j++)
            {
                lcm = lcm * nums[j] / Gcd(lcm, nums[j]);
                
                if (lcm == k)
                    result++;
            }
        }

        return result;
    }

    private static int Gcd(int a, int b)
    {
        return b == 0 ? a : Gcd(b, a % b);
    }
}
