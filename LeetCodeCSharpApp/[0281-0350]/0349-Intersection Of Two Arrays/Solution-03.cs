namespace LeetCodeCSharpApp.IntersectionOfTwoArrays03;

/// <summary>
///   Two Sets
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

        return set1.Count < set2.Count
            ? SetIntersection(set1, set2)
            : SetIntersection(set2, set1);
    }

    private static int[] SetIntersection(HashSet<int> set1, HashSet<int> set2)
    {
        return set1.Where(set2.Contains).ToArray();
    }
}
