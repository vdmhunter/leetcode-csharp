namespace LeetCodeCSharpApp.MinimumOperationsToMaximizeLastElementsInArrays01;

public class Solution
{
    public int MinOperations(int[] nums1, int[] nums2)
    {
        int dp1 = 0, dp2 = 0, n = nums1.Length;
        int mi = Math.Min(nums1[n - 1], nums2[n - 1]), ma = Math.Max(nums1[n - 1], nums2[n - 1]);

        for (var i = 0; i < n; i++)
        {
            int a = nums1[i], b = nums2[i];

            if (IsOutOfRange(a, b, ma, mi))
                return -1;

            UpdateDpValues(a, b, nums1[n - 1], nums2[n - 1], ref dp1, ref dp2);
        }

        return Math.Min(dp1, dp2);
    }

    private static bool IsOutOfRange(int a, int b, int ma, int mi)
    {
        return Math.Max(a, b) > ma || Math.Min(a, b) > mi;
    }

    private static void UpdateDpValues(int a, int b, int num1, int num2, ref int dp1, ref int dp2)
    {
        if (a > num1 || b > num2)
            dp1++;

        if (a > num2 || b > num1)
            dp2++;
    }
}
