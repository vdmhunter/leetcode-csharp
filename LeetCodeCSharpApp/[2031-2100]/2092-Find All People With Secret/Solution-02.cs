namespace LeetCodeCSharpApp.FindAllPeopleWithSecret02;

/// <summary>
///     Depth First Search
///
///     Time complexity: O(m * (m + n))
///     Space complexity: O(m + n)
/// </summary>
public class Solution
{
    public IList<int> FindAllPeople(int n, int[][] meetings, int firstPerson)
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

        Dfs(0, 0, graph, earliest);
        Dfs(firstPerson, 0, graph, earliest);

        return earliest
            .Select((val, idx) => val != int.MaxValue ? idx : -1)
            .Where(idx => idx != -1)
            .ToList();
    }

    private static void Dfs(int person, int time, Dictionary<int, List<int[]>> graph, int[] earliest)
    {
        if (!graph.TryGetValue(person, out List<int[]>? value))
            return;

        foreach (int[] nextPersonTime in value)
        {
            int t = nextPersonTime[0], nextPerson = nextPersonTime[1];

            if (t < time || earliest[nextPerson] <= t)
                continue;

            earliest[nextPerson] = t;
            Dfs(nextPerson, t, graph, earliest);
        }
    }
}
