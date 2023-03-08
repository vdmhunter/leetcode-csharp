namespace LeetCodeCSharpApp.KokoEatingBananas01;

public class Solution
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        var l = 1;
        var r = piles.Max();

        while (l < r)
        {
            var m = l + (r - l) / 2;

            if (IsEnough(piles, m, h))
                r = m;
            else
                l = m + 1;
        }

        return l;
    }

    private bool IsEnough(int[] piles, int k, int h)
    {
        var hours = piles.Sum(pile => (pile + k - 1) / k);

        return hours <= h;
    }
}
