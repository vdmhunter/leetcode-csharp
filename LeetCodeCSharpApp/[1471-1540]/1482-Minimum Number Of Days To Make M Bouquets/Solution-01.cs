namespace LeetCodeCSharpApp.MinimumNumberOfDaysToMakeMBouquets01;

public class Solution
{
    public int MinDays(int[] bloomDay, int m, int k)
    {
        int left = bloomDay.Min();
        int right = bloomDay.Max();

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (CanMakeBouquetsAtDay(mid))
                right = mid;
            else
                left = mid + 1;
        }

        return CanMakeBouquetsAtDay(left) ? left : -1;

        bool CanMakeBouquetsAtDay(int day)
        {
            var bouquets = 0;
            var adjacent = 0;

            foreach (int bloom in bloomDay)
            {
                adjacent = bloom <= day ? adjacent + 1 : 0;
                bouquets = adjacent == k ? bouquets + 1 : bouquets;
                adjacent = adjacent == k ? 0 : adjacent;
            }

            return bouquets >= m;
        }
    }
}
