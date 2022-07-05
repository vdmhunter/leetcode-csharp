namespace LeetCodeCSharpApp.ContainsDuplicate01;

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        return nums.GroupBy(entry => entry).Any(entry => entry.Count() > 1);
    }
}
