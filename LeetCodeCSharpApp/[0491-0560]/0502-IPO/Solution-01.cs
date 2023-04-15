namespace LeetCodeCSharpApp.IPO01;

public class Solution
{
    public int FindMaximizedCapital(int k, int w, int[] profits, int[] capital)
    {
        Array.Sort(capital, profits);
        var pq = new PriorityQueue<int, int>();
        var index = 0;

        while (k > 0)
        {
            while (index < profits.Length && w >= capital[index])
            {
                pq.Enqueue(profits[index], -profits[index]);
                index++;
            }

            if (pq.Count == 0)
                return w;

            w += pq.Dequeue();
            k--;
        }

        return w;
    }
}
