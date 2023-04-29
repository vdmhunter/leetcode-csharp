namespace LeetCodeCSharpApp.ConstructTargetArrayWithMultipleSums01;

/// <summary>
/// Priority Queue
/// </summary>
public class Solution
{
    public bool IsPossible(int[] target)
    {
        var pq = new PriorityQueue<int, int>();
        var total = 0L;

        foreach (var a in target)
        {
            total += a;
            pq.Enqueue(a, -a);
        }

        while (true)
        {
            var a = pq.Dequeue();
            total -= a;

            if (a == 1 || total == 1)
                return true;

            if (a < total || total == 0 || a % total == 0)
                return false;

            a = Convert.ToInt32(a % total);
            total += a;
            pq.Enqueue(a, -a);
        }
    }
}
