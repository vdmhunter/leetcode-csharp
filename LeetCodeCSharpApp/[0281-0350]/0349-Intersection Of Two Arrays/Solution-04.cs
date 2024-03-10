namespace LeetCodeCSharpApp.IntersectionOfTwoArrays04;

/// <summary>
///   One Dictionary
///
///   Time complexity: O(N + M) in the average case and O(N * M) in the worst case
///   Space complexity: O(N)
/// </summary>
public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        var seen = new Dictionary<int, int>();
        var result = new List<int>();

        foreach (int x in nums1)
            seen[x] = 1;

        foreach (int x in nums2)
        {
            if (!seen.TryGetValue(x, out int value) || value != 1)
                continue;

            result.Add(x);
            seen[x] = 0;
        }

        return result.ToArray();
    }
}
