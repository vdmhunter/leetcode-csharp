namespace LeetCodeCSharpApp.SortColors02;

public class Solution
{
    public void SortColors(int[] nums)
    {
        for (var i = 0; i < nums.Length; i++)
            for (int j = i + 1; j < nums.Length; j++)
                if (nums[i] > nums[j])
                    (nums[i], nums[j]) = (nums[j], nums[i]);
    }
}
