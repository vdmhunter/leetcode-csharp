namespace LeetCodeCSharpApp._2591_2660_.The_Number_Of_Beautiful_Subsets;

public class Solution
{
    public int BeautifulSubsets(int[] nums, int k, int i = 0, int mask = 0)
    {
        if (i == nums.Length)
            return mask > 0 ? 1 : 0;

        var bfl = true;

        for (var j = 0; j < i && bfl; ++j)
            bfl = ((1 << j) & mask) == 0 || Math.Abs(nums[j] - nums[i]) != k;

        return BeautifulSubsets(nums, k, i + 1, mask) +
               (bfl ? BeautifulSubsets(nums, k, i + 1, mask + (1 << i)) : 0);
    }
}

