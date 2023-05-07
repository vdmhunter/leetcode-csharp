namespace LeetCodeCSharpApp.FindTheDistinctDifferenceArray01;

public class Solution
{
    public int[] DistinctDifferenceArray(int[] nums)
    {
        var n = nums.Length;
        var result = new int[n];
        
        for (var i = 0; i < n; i++)
            result[i] = nums[..(i + 1)].Distinct().Count() - nums[(i + 1)..].Distinct().Count();

        return result;
    }
}
