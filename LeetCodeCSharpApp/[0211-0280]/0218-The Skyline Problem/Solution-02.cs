namespace LeetCodeCSharpApp.TheSkylineProblem02;

public class Solution
{
    public IList<IList<int>> GetSkyline(int[][] buildings)
    {
        var list = new List<int[]>();
        var n = buildings.Length;

        for (var i = 0; i < n; i++)
        {
            list.Add(new[] { buildings[i][0], i });
            list.Add(new[] { buildings[i][1], i });
        }

        list = list.OrderBy(o => o[0]).ToList();

        var pq = new PriorityQueue<int[], int>();
        var idx = 0;
        var result = new List<IList<int>>();

        while (idx < list.Count)
        {
            var cur = list[idx][0];

            while (idx < list.Count && list[idx][0] == cur)
            {
                var b = list[idx][1];

                if (buildings[b][0] == cur)
                {
                    var right = buildings[b][1];
                    var height = buildings[b][2];
                    pq.Enqueue(new[] { height, right }, -height);
                }

                idx++;
            }

            while (pq.Count > 0 && pq.Peek()[1] <= cur)
                pq.Dequeue();

            var curHeight = pq.Count == 0 ? 0 : pq.Peek()[0];

            if (result.Count == 0 || result[^1][1] != curHeight)
                result.Add(new List<int> { cur, curHeight });
        }

        return result;
    }
}
