namespace LeetCodeCSharpApp.IntersectionOfTwoArrays01;

/// <summary>
///   Sorting and Two Pointers
///
///   Time complexity: O(N * Log(N) + M * Log(M))
///   Space complexity: O(N + M)
/// </summary>
public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        Array.Sort(nums1);
        Array.Sort(nums2);

        int n = nums1.Length;
        int m = nums2.Length;
        var p1 = 0;
        var p2 = 0;

        var intersection = new HashSet<int>();

        while (p1 < n && p2 < m)
        {
            if (nums1[p1] == nums2[p2])
            {
                intersection.Add(nums1[p1]);
                p1++;
                p2++;
            }
            else if (nums1[p1] < nums2[p2])
            {
                p1++;
            }
            else
            {
                p2++;
            }
        }

        var result = new int[intersection.Count];
        var curr = 0;

        foreach (int x in intersection)
            result[curr++] = x;

        return result;
    }
}
