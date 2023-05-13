namespace LeetCodeCSharpApp.MaximumOR01;

public class Solution
{
    public long MaximumOr(int[] nums, int k)
    {
        var n = nums.Length;
        var pre = new long[n + 1]; // Stores prefix bitwise OR values
        var suf = new long[n + 1]; // Stores suffix bitwise OR values

        pre[0] = 0L;
        suf[n] = 0L;
        
        var result = 0L;
        var p = 1L; // Used to calculate the power of 2, equivalent to x^k
        p <<= k; // Left shift k positions to calculate 2^k

        // Calculate prefix bitwise OR values
        for (var i = 0; i < n; i++)
            pre[i + 1] = pre[i] | (uint)nums[i];

        // Calculate suffix bitwise OR values
        for (var i = n - 1; i >= 0; i--)
            suf[i] = suf[i + 1] | (uint)nums[i];

        // Find the maximum result by iterating through the numbers
        for (var i = 0; i < n; i++)
            result = Math.Max(result, pre[i] | nums[i] * p | suf[i + 1]);

        return result;
    }
}
