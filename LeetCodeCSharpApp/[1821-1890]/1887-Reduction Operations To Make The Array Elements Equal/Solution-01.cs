namespace LeetCodeCSharpApp.ReductionOperationsToMakeTheArrayElementsEqual01;

public class Solution
{
    public int ReductionOperations(int[] nums)
    {
        int result = 0, size = nums.Length;

        Array.Sort(nums);

        for (var j = size - 1; j > 0; --j)
            if (nums[j - 1] != nums[j])
                result += size - j;

        return result;
    }
}
