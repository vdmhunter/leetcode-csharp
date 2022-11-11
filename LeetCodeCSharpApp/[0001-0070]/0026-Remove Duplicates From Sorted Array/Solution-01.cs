namespace LeetCodeCSharpApp.RemoveDuplicatesFromSortedArray01;

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        var i = nums.Length > 0 ? 1 : 0;

        foreach (var n in nums)
            if (n > nums[i - 1])
                nums[i++] = n;

        return i;
    }
}
