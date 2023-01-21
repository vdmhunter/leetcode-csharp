namespace LeetCodeCSharpApp.MaximumSubsequenceScore01;

public class Solution
{
    public long MaxScore(int[] nums1, int[] nums2, int k)
    {
        var n = nums1.Length;
        var ess = new int[n][];

        for (var i = 0; i < n; ++i)
            ess[i] = new[] { nums2[i], nums1[i] };
        
        Array.Sort(ess, (a, b) => b[0] - a[0]);

        var pq = new PriorityQueue<int, int>(k);
        long result = 0, sumS = 0;

        foreach (var es in ess)
        {
            pq.Enqueue(es[1], es[1]);
            sumS += es[1];

            if (pq.Count > k)
                sumS -= pq.Dequeue();

            if (pq.Count == k)
                result = Math.Max(result, sumS * es[0]);
        }

        return result;
    }
}
