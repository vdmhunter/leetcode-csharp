namespace LeetCodeCSharpApp.MinimumTimeToCompleteTrips01;

public class Solution
{
    public long MinimumTime(int[] time, int totalTrips)
    {
        var left = 0L;
        var right = (long)1e14;

        while (left <= right)
        {
            var mid = left + (right - left) / 2;
            var sum = time.Sum(t => mid / t);

            if (sum < totalTrips)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return left;
    }
}
