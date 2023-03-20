namespace LeetCodeCSharpApp.CanPlaceFlowers01;

public class Solution
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        var count = 0;

        for (var i = 0; i < flowerbed.Length && count < n; i++)
            if (flowerbed[i] == 0)
            {
                var next = i == flowerbed.Length - 1 ? 0 : flowerbed[i + 1];
                var prev = i == 0 ? 0 : flowerbed[i - 1];

                if (next != 0 || prev != 0)
                    continue;

                flowerbed[i] = 1;
                count++;
            }

        return count == n;
    }
}
