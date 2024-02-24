namespace LeetCodeCSharpApp.FindAllPeopleWithSecret04;

/// <summary>
///     Breadth First Search on Time Scale
///
///     Time complexity: O(m * log(m + n))
///     Space complexity: O(m + n)
/// </summary>
public class Solution
{
    public IList<int> FindAllPeople(int n, int[][] meetings, int firstPerson)
    {
        Array.Sort(meetings, (a, b) => a[2] - b[2]);

        Dictionary<int, List<int[]>> sameTimeMeetings = meetings
            .GroupBy(m => m[2])
            .ToDictionary(
                g => g.Key,
                g => g.Select(m => new[] { m[0], m[1] }).ToList()
            );

        bool[] knowsSecret = [true, ..Enumerable.Repeat(false, n - 1)];
        knowsSecret[firstPerson] = true;

        foreach (int t in sameTimeMeetings.Keys)
        {
            Dictionary<int, List<int>> meet = sameTimeMeetings[t]
                .SelectMany(m => new[] { (m[0], m[1]), (m[1], m[0]) })
                .GroupBy(pair => pair.Item1)
                .ToDictionary(
                    g => g.Key,
                    g => g.Select(pair => pair.Item2).ToList()
                );

            HashSet<int> start = sameTimeMeetings[t]
                .SelectMany(meeting => new[] { meeting[0], meeting[1] })
                .Where(person => knowsSecret[person])
                .ToHashSet();

            var q = new Queue<int>(start);

            while (q.Count > 0)
            {
                int person = q.Dequeue();

                foreach (int nextPerson in meet.GetValueOrDefault(person, []).Where(np => !knowsSecret[np]))
                {
                    knowsSecret[nextPerson] = true;
                    q.Enqueue(nextPerson);
                }
            }
        }

        return Enumerable.Range(0, n).Where(i => knowsSecret[i]).ToList();
    }
}
