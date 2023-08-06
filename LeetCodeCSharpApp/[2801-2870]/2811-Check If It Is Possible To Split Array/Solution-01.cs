namespace LeetCodeCSharpApp.CheckIfItIsPossibleToSplitArray01;

public class Solution
{
    public bool CanSplitArray(IList<int> nums, int m)
    {
        for (var i = 1; i < nums.Count; i++)
            if (nums[i - 1] + nums[i] >= m)
                return true;

        return nums.Count <= 2;
    }
}
