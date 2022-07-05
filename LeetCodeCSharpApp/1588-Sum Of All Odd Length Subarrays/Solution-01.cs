namespace LeetCodeCSharpApp.SumOfAllOddLengthSubarrays01;

public class Solution
{
    public int SumOddLengthSubarrays(int[] arr)
    {
        int res = 0, n = arr.Length;
        
        for (var i = 0; i < n; ++i)
            res += ((i + 1) * (n - i) + 1) / 2 * arr[i];
        
        return res;
    }
}
