namespace LeetCodeCSharpApp.MinimumOperationsToMakeArrayEqualII01;

public class Solution
{
    public long MinOperations(int[] nums1, int[] nums2, int k)
    {
        var n = nums1.Length;
        var flag = true;
        long pos = 0L, neg = 0L;

        for (var i = 0; i < n; i++)
        {
            var diff = nums2[i] - nums1[i];

            if (diff != 0)
                flag = false;

            if (k != 0 && diff % k != 0)
                return -1;

            pos += diff > 0 ? diff : 0;
            neg += diff < 0 ? -diff : 0;
        }

        if (pos != neg)
            return -1;

        if (flag)
            return 0;

        if (k == 0)
            return -1;

        return pos / k;
    }
}
