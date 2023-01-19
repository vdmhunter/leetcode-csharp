namespace LeetCodeCSharpApp.SubarraySumsDivisibleByK01;

public class Solution
{
    public int SubarraysDivByK(int[] nums, int k)
    {
        var count = new int[k];
        count[0] = 1;
        int prefix = 0, result = 0;

        foreach (var n in nums)
        {
            prefix = (prefix + n % k + k) % k;
            result += count[prefix]++;
        }

        return result;
    }
}
