namespace LeetCodeCSharpApp.MinimumRoundsToCompleteAllTasks01;

public class Solution
{
    public int MinimumRounds(int[] tasks)
    {
        var counts = tasks.GroupBy(x => x).Select(x => x.Count()).ToArray();
        
        return counts.Any(x => x == 1)
            ? -1
            : counts.Sum(x => (x + 2) / 3);
    }
}
