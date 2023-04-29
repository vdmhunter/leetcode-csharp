namespace LeetCodeCSharpApp.MaximizeTheMinimumPoweredCity01;

public class Solution
{
    public long MaxPower(int[] stations, int r, int k)
    {
        var low = (long)stations.Min();
        var high = stations.Sum(i => (long)i) + k;
        var result = 0L;

        while (low <= high)
        {
            var mid = low + (high - low) / 2;

            if (IsValid(stations, r, mid, k))
            {
                result = mid;
                low = mid + 1;
            }
            else
                high = mid - 1;
        }

        return result;
    }

    private bool IsValid(int[] stations, int r, long requiredPower, long k)
    {
        var windowPower = 0L;
        var additions = new long[stations.Length];

        for (var i = 0; i < r; i++)
            windowPower += stations[i];

        for (var i = 0; i < stations.Length; i++)
        {
            if (i + r < stations.Length)
                windowPower += stations[i + r] + additions[i + r];

            if (!Helper(i))
                return false;

            if (i - r >= 0)
                windowPower -= stations[i - r] + additions[i - r];
        }

        #region Helper

        bool Helper(int i)
        {
            if (windowPower >= requiredPower)
                return true;

            var needed = requiredPower - windowPower;

            if (needed > k)
                return false;

            additions[Math.Min(stations.Length - 1, i + r)] += needed;
            windowPower = requiredPower;
            k -= needed;

            return true;
        }

        #endregion

        return true;
    }
}
