namespace LeetCodeCSharpApp.TotalCostToHireKWorkers01;

public class Solution
{
    public long TotalCost(int[] costs, int k, int candidates)
    {
        var pq1 = new PriorityQueue<int, int>();
        var pq2 = new PriorityQueue<int, int>();
        int i = 0, j = costs.Length - 1;
        var totalCost = 0L;

        while (k > 0)
        {
            while (pq1.Count < candidates && i <= j)
            {
                pq1.Enqueue(costs[i], costs[i]);
                i++;
            }

            while (pq2.Count < candidates && j >= i)
            {
                pq2.Enqueue(costs[j], costs[j]);
                j--;
            }

            var p1 = pq1.Count > 0 ? pq1.Peek() : int.MaxValue;
            var p2 = pq2.Count > 0 ? pq2.Peek() : int.MaxValue;

            if (p1 <= p2)
            {
                totalCost += p1;
                pq1.TryDequeue(out _, out _);
            }
            else
            {
                totalCost += p2;
                pq2.TryDequeue(out _, out _);
            }

            k--;
        }

        return totalCost;
    }
}
