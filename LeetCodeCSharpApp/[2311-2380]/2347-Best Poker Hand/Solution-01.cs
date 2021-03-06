namespace LeetCodeCSharpApp.BestPokerHand01;

public class Solution
{
    public string BestHand(int[] ranks, char[] suits)
    {
        if (suits.Distinct().Count() == 1)
            return "Flush";

        var count = ranks
            .GroupBy(r => r)
            .Select(g => new { r = g.Key, c = g.Count() })
            .OrderByDescending(g => g.c)
            .First().c;

        return count switch
        {
            >= 3 => "Three of a Kind",
            >= 2 => "Pair",
            _ => "High Card"
        };
    }
}
