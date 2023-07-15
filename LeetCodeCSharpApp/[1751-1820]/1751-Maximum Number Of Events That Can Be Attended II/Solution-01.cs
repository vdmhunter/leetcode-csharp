namespace LeetCodeCSharpApp.MaximumNumberOfEventsThatCanBeAttendedII01;

public class Solution
{
    public int MaxValue(int[][] events, int k)
    {
        // Sort events by endDay
        Array.Sort(events, (a, b) => a[1].CompareTo(b[1]));

        // Prepare for dp
        var n = events.Length;
        var dp = new int[n + 1, k + 1];

        // Create new events array with dummy first event
        var newEvents = new[] { new[] { 0, 0, 0 } }.Concat(events).ToArray();

        // Main dp process
        for (var i = 1; i <= n; i++)
        {
            for (var j = 1; j <= k; j++)
            {
                // Without attending event i
                dp[i, j] = dp[i - 1, j];

                // Find non-overlapping event
                var index = FindNonOverlappingEvent(i, newEvents);

                // Consider attending event i
                dp[i, j] = Math.Max(dp[i, j], newEvents[i][2] + dp[index, j - 1]);
            }
        }

        // Return best result
        return Enumerable.Range(0, k + 1).Max(j => dp[n, j]);
    }

    private static int FindNonOverlappingEvent(int i, int[][] newEvents)
    {
        int l = 0, r = i - 1;

        while (l < r)
        {
            var mid = (l + r + 1) / 2;

            if (newEvents[mid][1] < newEvents[i][0])
                l = mid;
            else
                r = mid - 1;
        }

        return l;
    }
}
