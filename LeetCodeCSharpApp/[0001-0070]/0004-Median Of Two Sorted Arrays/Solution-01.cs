namespace LeetCodeCSharpApp.MedianOfTwoSortedArrays01;

public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var merged = new List<int>();
        int i = 0, j = 0;

        while (i < nums1.Length && j < nums2.Length)
            merged.Add(nums1[i] < nums2[j] ? nums1[i++] : nums2[j++]);

        while (i < nums1.Length)
            merged.Add(nums1[i++]);

        while (j < nums2.Length)
            merged.Add(nums2[j++]);

        var mid = merged.Count / 2;

        if (merged.Count % 2 == 0)
            return (merged[mid - 1] + merged[mid]) / 2.0;

        return merged[mid];
    }
}
