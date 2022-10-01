namespace LeetCodeCSharpApp.FindKClosestElements01;

/// <summary>
/// Priority Queue
/// </summary>
public class Solution
{
    public IList<int> FindClosestElements(int[] arr, int k, int x)
    {
        // For priority use first the distance from x (|x - nums[i]|),
        // second use the number it self since u have to choose the smallest in case of equal distance
        var pq = new PriorityQueue<int, (int, int)>();
        pq.EnqueueRange(arr.Select(v => (v, (Math.Abs(v - x), v))));
        var result = new List<int>();

        while (k-- > 0)
            result.Add(pq.Dequeue());

        result.Sort();

        return result;
    }
}
