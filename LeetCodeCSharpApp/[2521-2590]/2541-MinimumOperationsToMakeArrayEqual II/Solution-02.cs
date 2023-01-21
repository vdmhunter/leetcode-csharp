namespace LeetCodeCSharpApp.MinimumOperationsToMakeArrayEqualII02;

public class Solution
{
    public long MinOperations(int[] nums1, int[] nums2, int k)
    {
        if (k == 0)
            return nums1.SequenceEqual(nums2) ? 0 : -1;

        long result = 0, balance = 0;

        for (var i = 0; i < nums1.Length; ++i)
        {
            var diff = nums1[i] - nums2[i];

            if (diff % k != 0)
                return -1;

            if (diff > 0)
                result += diff / k;

            balance += diff;
        }

        return balance == 0 ? result : -1;
    }
}
