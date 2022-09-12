namespace LeetCodeCSharpApp.MaximumPerformanceOfATeam01;

public class Solution
{
    public int MaxPerformance(int n, int[] speed, int[] efficiency, int k)
    {
        var records = new int[n][];
        long result = 0;
        
        for (var i = 0; i < n; i++) records[i] = new int[2];
            for (var i = 0; i < n; i++)
            {
                records[i][0] = efficiency[i];
                records[i][1] = speed[i];
            }

        Array.Sort(records, (a, b) => b[0] - a[0]);

        var speedSum = 0L;
        var minHeap = new PriorityQueue<int, int>();

        for (var i = 0; i < n; i++)
        {
            if (minHeap.Count == k)
            {
                var minSpeed = minHeap.Dequeue();
                speedSum -= minSpeed;
            }

            speedSum += records[i][1];
            minHeap.Enqueue(records[i][1], records[i][1]);
            result = Math.Max(result, speedSum * records[i][0]);
        }

        return (int)(result % 1000000007);
    }
}
