// ReSharper disable EmptyEmbeddedStatement

namespace LeetCodeCSharpApp.MaximumNumberOfEventsThatCanBeAttendedII02;

public class Solution
{
    public int MaxValue(int[][] events, int k)
    {
        Array.Sort(events, (a, b) => a[0].CompareTo(b[0]));
        
        var n = events.Length;
        var dp = new int[n, k];

        for (var i = 0; i < n; i++)
            for (var j = 0; j < k; j++)
                dp[i, j] = -1;

        return Dp(0, k);

        int Dp(int eventIdx, int remainingK)
        {
            if (remainingK <= 0)
                return 0;

            if (eventIdx >= events.Length)
                return 0;

            if (dp[eventIdx, remainingK - 1] > -1)
                return dp[eventIdx, remainingK - 1];

            var result = 0;
            result += events[eventIdx][2];

            var nextEventIdx = eventIdx;

            while (++nextEventIdx < n && events[nextEventIdx][0] <= events[eventIdx][1]);
            result += Dp(nextEventIdx, remainingK - 1);

            result = Math.Max(result, Dp(eventIdx + 1, remainingK));
            dp[eventIdx, remainingK - 1] = result;

            return result;
        }
    }
}
