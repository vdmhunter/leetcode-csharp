namespace LeetCodeCSharpApp.FindAllPeopleWithSecret03;

/// <summary>
///     Earliest Informed First Traversal
///
///     Time complexity: O((n + m) * log(n + m) + n * m)
///     Space complexity: O(m + n)
/// </summary>
public class Solution
{
    public List<int> FindAllPeople(int n, int[][] meetings, int firstPerson)
    {
        Dictionary<int, List<int[]>> graph = meetings
            .SelectMany(meeting => new[]
            {
                (x: meeting[0], y: meeting[1], t: meeting[2]),
                (x: meeting[1], y: meeting[0], t: meeting[2])
            })
            .GroupBy(tuple => tuple.x)
            .ToDictionary(
                group => group.Key,
                group => group.Select(tuple => new[] { tuple.t, tuple.y }).ToList()
            );

        var pq = new PriorityQueue<int[], int>([([0, 0], 0), ([0, firstPerson], 0)]);
        var visited = new bool[n];

        while (pq.Count > 0)
        {
            int[] timePerson = pq.Dequeue();
            int time = timePerson[0], person = timePerson[1];

            if (visited[person])
                continue;

            visited[person] = true;

            if (!graph.ContainsKey(person))
                continue;

            graph[person]
                .Where(nextPersonTime => !visited[nextPersonTime[1]] && nextPersonTime[0] >= time)
                .ToList()
                .ForEach(nextPersonTime => pq.Enqueue([nextPersonTime[0], nextPersonTime[1]], nextPersonTime[0]));
        }

        return Enumerable.Range(0, n).Where(i => visited[i]).ToList();
    }
}
