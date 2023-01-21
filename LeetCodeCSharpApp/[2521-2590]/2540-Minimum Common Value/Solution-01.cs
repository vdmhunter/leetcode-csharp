namespace LeetCodeCSharpApp.MinimumCommonValue01;

public class Solution
{
    public int GetCommon(int[] nums1, int[] nums2)
    {
        var i = 0;
        var j = 0;
        var min = int.MaxValue;

        while (i < nums1.Length && j < nums2.Length)
            if (nums1[i] == nums2[j])
            {
                min = Math.Min(min, nums1[i]);
                i++;
                j++;
            }
            else if (nums1[i] < nums2[j])
                i++;
            else
                j++;

        return min == int.MaxValue ? -1 : min;
    }
}
