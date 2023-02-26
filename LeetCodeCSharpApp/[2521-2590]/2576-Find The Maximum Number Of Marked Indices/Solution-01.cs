namespace LeetCodeCSharpApp._2521_2590_.Find_The_Maximum_Number_Of_Marked_Indices;

public class Solution
{
    public int MaxNumOfMarkedIndices(int[] nums)
    {
        Array.Sort(nums);
        var n = nums.Length;
        int first = 0, second = (nums.Length + 1) / 2;

        while (second < n)
        {
            if (nums[first] * 2 <= nums[second])
                first++;

            second++;
        }

        return first * 2;
    }
}
