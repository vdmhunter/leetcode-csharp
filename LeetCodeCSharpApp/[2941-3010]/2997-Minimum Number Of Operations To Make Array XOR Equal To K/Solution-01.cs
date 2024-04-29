namespace LeetCodeCSharpApp.MinimumNumberOfOperationsToMakeArrayXOREqualToK01;

public class Solution
{
    public int MinOperations(int[] nums, int k)
    {
        k = nums.Aggregate(k, (current, n) => current ^ n);

        return Convert.ToString(k, 2).Count(c => c == '1');
    }
}
