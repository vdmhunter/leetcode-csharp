namespace LeetCodeCSharpApp.MaximizeGreatnessOfAnArray01;

public class Solution
{
    public int MaximizeGreatness(int[] nums)
    {
        Array.Sort(nums);
        var result = 0;

        foreach (var n in nums)
            if (n > nums[result])
                result++;

        return result;
    }
}
