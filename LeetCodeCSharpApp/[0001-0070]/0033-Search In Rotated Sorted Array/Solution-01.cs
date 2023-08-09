namespace LeetCodeCSharpApp.SearchInRotatedSortedArray01;

public class Solution
{
    public int Search(int[] nums, int target)
    {
        int low = 0, high = nums.Length - 1;

        while (low <= high)
        {
            var mid = (low + high) / 2;

            if (nums[mid] == target)
                return mid;

            if (nums[low] <= nums[mid])
            {
                var l = low;
                UpdateHiLow(() => target <= nums[mid] && target >= nums[l], ref high, mid, ref low);
            }
            else
            {
                var h = high;
                UpdateHiLow(() => target < nums[mid] || target > nums[h], ref high, mid, ref low);
            }
        }

        return -1;
    }

    private static void UpdateHiLow(Func<bool> f, ref int high, int mid, ref int low)
    {
        if (f())
            high = mid - 1;
        else
            low = mid + 1;
    }
}
