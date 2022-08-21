namespace LeetCodeCSharpApp.MinimumNumberOfRefuelingStops01;

public class Solution
{
    public int MinRefuelStops(int target, int startFuel, int[][] stations)
    {
        int index = 0, count = 0;
        var pq = new PriorityQueue<int, int>();
        
        while (startFuel < target)
        {
            while (index != stations.Length && stations[index][0] <= startFuel)
            {
                pq.Enqueue(stations[index][1], -stations[index][1]);
                index++;
            }
            
            if (pq.Count == 0)
                return -1;
            
            startFuel += pq.Dequeue();
            count++;
        }
        
        return count;
    }
}
