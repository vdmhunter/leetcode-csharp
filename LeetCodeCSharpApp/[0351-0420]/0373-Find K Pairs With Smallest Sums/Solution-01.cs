namespace LeetCodeCSharpApp.FindKPairsWithSmallest_Sums01;

public class Solution
{
    public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k)
    {
        var swap = false;

        if (nums1.Length > nums2.Length)
        {
            (nums1, nums2) = (nums2, nums1);
            swap = true;
        }

        var result = new List<IList<int>>(k);
        var pq = new PriorityQueue<(int, int), int>(k < nums1.Length ? k : nums1.Length);

        for (var i = 0; i < nums1.Length && i < k; i++)
            pq.Enqueue((i, 0), nums1[i] + nums2[0]);

        while (k-- > 0 && pq.TryPeek(out (int x, int y) t, out _))
        {
            pq.Dequeue();

            result.Add(swap
                ? new List<int> { nums2[t.y], nums1[t.x] }
                : new List<int> { nums1[t.x], nums2[t.y] });

            if (t.y + 1 < nums2.Length)
                pq.Enqueue((t.x, t.y + 1), nums1[t.x] + nums2[t.y + 1]);
        }

        return result;
    }
}
