namespace LeetCodeCSharpApp.LastStoneWeight01;

public class Solution
{
    public int LastStoneWeight(int[] stones)
    {
        var pq = new PriorityQueue<int, int>();

        foreach (var s in stones)
            pq.Enqueue(s, -s);

        while (pq.Count > 1)
        {
            var s = pq.Dequeue() - pq.Dequeue();
            pq.Enqueue(s, -s);
        }

        return pq.Dequeue();
    }
}
