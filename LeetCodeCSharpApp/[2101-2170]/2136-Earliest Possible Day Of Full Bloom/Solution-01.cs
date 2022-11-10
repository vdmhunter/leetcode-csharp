namespace LeetCodeCSharpApp.EarliestPossibleDayOfFullBloom01;

public class Solution
{
    public int EarliestFullBloom(int[] plantTime, int[] growTime)
    {
        var n = plantTime.Length;
        var times = new List<(int First, int Second)>(n);

        for (var i = 0; i < n; i++)
            times.Add((First: -growTime[i], Second: plantTime[i]));

        times.Sort();

        var result = 0;
        var curr = 0;

        for (var i = 0; i < n; i++)
        {
            result = Math.Max(result, curr + times[i].Second - times[i].First);
            curr += times[i].Second;
        }

        return result;
    }
}
