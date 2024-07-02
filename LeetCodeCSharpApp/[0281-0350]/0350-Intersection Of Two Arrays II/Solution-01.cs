namespace LeetCodeCSharpApp.IntersectionOfTwoArraysII01;

public class Solution
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        int l1 = nums1.Length;
        int l2 = nums2.Length;
        int i = 0, j = 0, k = 0;

        Array.Sort(nums1);
        Array.Sort(nums2);
        
        while (i < l1 && j < l2)
        {
            if (nums1[i] < nums2[j])
            {
                i++;
            }
            else if (nums1[i] > nums2[j])
            {
                j++;
            }
            else
            {
                nums1[k++] = nums1[i++];
                j++;
            }
        }

        return nums1.Take(k).ToArray();
    }
}
