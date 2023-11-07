namespace LeetCodeCSharpApp.EliminateMaximumNumberOfMonsters01;

public class Solution
{
    public int EliminateMaximum(int[] dist, int[] speed)
    {
        dist = dist.Select((d, i) => (d - 1) / speed[i])
            .OrderBy(d => d)
            .ToArray();

        return Enumerable.Range(0, dist.Length)
            .TakeWhile(index => index <= dist[index])
            .Count();
    }
}
