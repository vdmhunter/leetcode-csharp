namespace LeetCodeCSharpApp.IntersectionOfTwoArrays02;

/// <summary>
///   Built-in Set Intersection
///
///   Time complexity: O(N + M)
///   Space complexity: O(N + M)
/// </summary>
public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        var set1 = new HashSet<int>(nums1);
        var set2 = new HashSet<int>(nums2);
        set1.IntersectWith(set2);
        var result = new int[set1.Count];
        var idx = 0;

        foreach (int s in set1)
            result[idx++] = s;

        return result;
    }
}
