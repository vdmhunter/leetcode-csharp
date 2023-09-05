namespace LeetCodeCSharpApp.MinimumSpeedToArriveOnTime01;

public class Solution
{
    public int MinSpeedOnTime(int[] dist, double hour)
    {
        var n = dist.Length;

        if (n - 1 > hour || hour - n + 1 <= 0)
            return -1;

        int left = 1, right = Math.Max(dist.Max(), (int)Math.Ceiling(dist[n - 1] / (hour - n + 1)));

        while (left < right)
        {
            var mid = left + (right - left) / 2;
            var totalTime = 0d;

            for (var i = 0; i < n - 1; i++)
                totalTime += Math.Ceiling((double)dist[i] / mid);

            totalTime += (double)dist[n - 1] / mid;

            if (totalTime <= hour)
                right = mid;
            else
                left = mid + 1;
        }

        return left;
    }
}
