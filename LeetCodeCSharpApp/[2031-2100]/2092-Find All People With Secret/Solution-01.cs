namespace LeetCodeCSharpApp.FindAllPeopleWithSecret01;

/// <summary>
///     Breadth First Search
///
///     Time complexity: O(m * (m + n))
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

        int[] earliest = [0, ..Enumerable.Repeat(int.MaxValue, n - 1)];
        earliest[firstPerson] = 0;

        var q = new Queue<int[]>([[0, 0], [firstPerson, 0]]);

        while (q.Count > 0)
        {
            int[] personTime = q.Dequeue();
            int person = personTime[0], time = personTime[1];

            if (!graph.ContainsKey(person))
                continue;

            foreach (int[] nextPersonTime in graph[person])
            {
                int t = nextPersonTime[0], nextPerson = nextPersonTime[1];

                if (t < time || earliest[nextPerson] <= t)
                    continue;

                earliest[nextPerson] = t;
                q.Enqueue([nextPerson, t]);
            }
        }

        return earliest
            .Select((val, idx) => val != int.MaxValue ? idx : -1)
            .Where(idx => idx != -1)
            .ToList();
    }
}
