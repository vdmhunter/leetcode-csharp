namespace LeetCodeCSharpApp.MedianOfTwoSortedArrays02;

public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        if (nums1.Length > nums2.Length)
            (nums1, nums2) = (nums2, nums1);

        var m = nums1.Length;
        var n = nums2.Length;
        int low = 0, high = m;

        while (low <= high)
        {
            var partitionX = (low + high) / 2;
            var partitionY = (m + n + 1) / 2 - partitionX;

            var maxX = GetMax(nums1, partitionX);
            var maxY = GetMax(nums2, partitionY);

            var minX = GetMin(nums1, partitionX);
            var minY = GetMin(nums2, partitionY);

            if (maxX <= minY && maxY <= minX)
                return CalculateMedian(maxX, maxY, minX, minY, m, n);

            if (maxX > minY)
                high = partitionX - 1;
            else
                low = partitionX + 1;
        }

        throw new ArgumentException("Input arrays are not sorted.");
    }

    private static int GetMax(int[] nums, int partition)
    {
        return partition == 0 ? int.MinValue : nums[partition - 1];
    }

    private static int GetMin(int[] nums, int partition)
    {
        return partition == nums.Length ? int.MaxValue : nums[partition];
    }

    private static double CalculateMedian(int maxX, int maxY, int minX, int minY, int m, int n)
    {
        if ((m + n) % 2 == 0)
            return (Math.Max(maxX, maxY) + Math.Min(minX, minY)) / 2.0;

        return Math.Max(maxX, maxY);
    }
}
