namespace LeetCodeCSharpApp.MakeArrayZeroBySubtractingEqualAmounts02;

public class Solution
{
    public int MinimumOperations(int[] nums)
    {
        return new HashSet<int>(nums.Where(n => n > 0)).Count;
    }
}
