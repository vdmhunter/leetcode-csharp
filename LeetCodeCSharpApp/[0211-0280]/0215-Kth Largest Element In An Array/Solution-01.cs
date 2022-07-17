namespace LeetCodeCSharpApp.KthLargestElementInAnArray01;

public class Solution
{
    public int FindKthLargest(int[] nums, int k)
    {
        var q = new PriorityQueue<int, int>(new Comparer());

        foreach (var n in nums)
            q.Enqueue(n, n);

        for (var i = 1; i < k; i++)
            q.Dequeue();

        return q.Peek();
    }
}

internal class Comparer : IComparer<int>
{
    public int Compare(int i1, int i2)
    {
        return i2 - i1;
    }
}
