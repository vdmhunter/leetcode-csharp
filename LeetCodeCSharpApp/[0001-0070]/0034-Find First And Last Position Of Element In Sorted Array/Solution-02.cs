namespace LeetCodeCSharpApp.FindFirstAndLastPositionOfElementInSortedArray02;

public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        int[] result = { -1, -1 };

        if (nums == null || nums.Length == 0)
            return result;

        result[0] = FindStartPosition(nums, target);
        result[1] = FindEndPosition(nums, target);

        return result;
    }

    private static int FindStartPosition(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length - 1;
        var start = -1;

        while (left <= right)
        {
            var mid = left + (right - left) / 2;

            if (nums[mid] == target)
            {
                start = mid; // This is start
                right = mid - 1; // Lets see if there one more on the left
            }
            else if (target > nums[mid])
                left = mid + 1;
            else
                right = mid - 1;
        }

        return start;
    }

    private static int FindEndPosition(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length - 1;
        var end = -1;

        while (left <= right)
        {
            var mid = left + (right - left) / 2;

            if (nums[mid] == target)
            {
                end = mid; // This is the end
                left = mid + 1; // Lets see if there is one more on the right
            }
            else if (target > nums[mid])
                left = mid + 1;
            else
                right = mid - 1;
        }

        return end;
    }
}
