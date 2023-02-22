namespace LeetCodeCSharpApp.CapacityToShipPackagesWithinDDays01;

public class Solution
{
    public int ShipWithinDays(int[] weights, int days)
    {
        int left = 0, right = 0;

        foreach (var w in weights)
        {
            left = Math.Max(left, w);
            right += w;
        }

        while (left < right)
        {
            int mid = (left + right) / 2, need = 1, cur = 0;

            foreach (var w in weights)
            {
                if (cur + w > mid)
                {
                    need += 1;
                    cur = 0;
                }

                cur += w;
            }

            if (need > days)
                left = mid + 1;

            else right = mid;
        }

        return left;
    }
}
