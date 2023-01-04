namespace LeetCodeCSharpApp.MinimumRoundsToCompleteAllTasks02;

public class Solution
{
    public int MinimumRounds(int[] tasks)
    {
        var count = new Dictionary<int, int>();

        foreach (var t in tasks)
        {
            count.TryGetValue(t, out var c);
            count[t] = c + 1;
        }

        var result = 0;

        foreach (var freq in count.Values)
        {
            if (freq == 1)
                return -1;

            result += (freq + 2) / 3;
        }

        return result;
    }
}
