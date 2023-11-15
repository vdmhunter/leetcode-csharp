namespace LeetCodeCSharpApp.MinimumOperationsToMaximizeLastElementsInArrays02;

public class Solution
{
    public int MinOperations(int[] nums1, int[] nums2)
    {
        var n = nums1.Length;
        var mi = Math.Min(nums1[n - 1], nums2[n - 1]);
        var ma = Math.Max(nums1[n - 1], nums2[n - 1]);

        var dp1 = nums1.Zip(nums2, (a, b) => new { a, b })
            .Count(pair => pair.a > nums1[n - 1] || pair.b > nums2[n - 1]);

        var dp2 = nums1.Zip(nums2, (a, b) => new { a, b })
            .Count(pair => pair.a > nums2[n - 1] || pair.b > nums1[n - 1]);

        if (nums1.Zip(nums2, (a, b) => new { a, b })
            .Any(pair => Math.Max(pair.a, pair.b) > ma || Math.Min(pair.a, pair.b) > mi))
        {
            return -1;
        }

        return Math.Min(dp1, dp2);
    }
}
