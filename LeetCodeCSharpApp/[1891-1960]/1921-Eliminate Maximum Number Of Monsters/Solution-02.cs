namespace LeetCodeCSharpApp.EliminateMaximumNumberOfMonsters02;

public class Solution
{
    public int EliminateMaximum(int[] dist, int[] speed)
    {
        for (var i = 0; i < dist.Length; i++)
            dist[i] = (dist[i] - 1) / speed[i];

        Array.Sort(dist);

        for (var i = 0; i < dist.Length; i++)
            if (i > dist[i])
                return i;

        return dist.Length;
    }
}
