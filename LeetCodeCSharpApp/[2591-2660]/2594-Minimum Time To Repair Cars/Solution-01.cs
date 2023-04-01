namespace LeetCodeCSharpApp.MinimumTimeToRepairCars01;

public class Solution
{
    public long RepairCars(int[] ranks, int cars)
    {
        long left = 1, right = 1L * ranks[0] * cars * cars;

        while (left < right)
        {
            long mid = (left + right) / 2, cur = 0;

            cur += ranks.Sum(r => (long)Math.Sqrt(1.0 * mid / r));

            if (cur < cars)
                left = mid + 1;
            else
                right = mid;
        }

        return left;
    }
}
