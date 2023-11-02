namespace LeetCodeCSharpApp.MajorityElementII01;

public class Solution
{
    public IList<int> MajorityElement(int[] nums)
    {
        return nums.GroupBy(num => num)
            .Where(group => group.Count() > nums.Length / 3)
            .Select(group => group.Key)
            .ToList();
    }
}
