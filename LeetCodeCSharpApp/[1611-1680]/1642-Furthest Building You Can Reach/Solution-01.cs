namespace LeetCodeCSharpApp.FurthestBuildingYouCanReach01;

/// <summary>
/// PriorityQueue
/// </summary>
public class Solution
{
    public int FurthestBuilding(int[] heights, int bricks, int ladders)
    {
        var pq = new PriorityQueue<int, int>();

        for (var i = 0; i < heights.Length - 1; i++)
        {
            var d = heights[i + 1] - heights[i];
            if (d > 0)
                pq.Enqueue(d, d);
            if (pq.Count > ladders)
                bricks -= pq.Dequeue();
            if (bricks < 0)
                return i;
        }

        return heights.Length - 1;
    }
}
