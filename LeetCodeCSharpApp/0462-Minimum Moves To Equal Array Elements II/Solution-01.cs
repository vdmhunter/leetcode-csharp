namespace LeetCodeCSharpApp.MinimumMovesToEqualArrayElementsII01;

public class Solution
{
    public int MinMoves2(int[] nums)
    {
        Array.Sort(nums);

        int i = 0, j = nums.Length - 1, count = 0;

        while (i < j)
            count += nums[j--] - nums[i++];

        return count;
    }
}
