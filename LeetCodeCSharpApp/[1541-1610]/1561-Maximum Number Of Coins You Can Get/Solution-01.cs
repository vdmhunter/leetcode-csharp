namespace LeetCodeCSharpApp.MaximumNumberOfCoinsYouCanGet01;

public class Solution
{
    public int MaxCoins(int[] piles)
    {
        Array.Sort(piles);

        int result = 0, n = piles.Length;

        for (var i = n / 3; i < n; i += 2)
            result += piles[i];

        return result;
    }
}
