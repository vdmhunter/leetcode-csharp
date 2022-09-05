namespace LeetCodeCSharpApp.BinarySearch01;

public class Solution
{
    public int Search(int[] nums, int target)
    {
        var low = 0;
        var high = nums.Length - 1;

        while (low <= high)
        {
            var mid = (low + high) / 2;
            
            if (nums[mid] == target)
                return mid;

            if (target > nums[mid])
                low = mid + 1;
            else
                high = mid - 1;
        }

        return -1;
    }
}
