// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMethodReturnValue.Global

namespace LeetCodeCSharpApp.KthLargestElementInAStream01;

public class KthLargest
{
    private readonly PriorityQueue<int, int> _pq;

    private readonly int _k;

    public KthLargest(int k, int[] nums)
    {
        _k = k;
        _pq = new PriorityQueue<int, int>();

        foreach (var num in nums)
            Add(num);
    }

    public int Add(int val)
    {
        _pq.Enqueue(val, val);

        while (_pq.Count > _k)
            _pq.Dequeue();

        return _pq.Peek();
    }
}
