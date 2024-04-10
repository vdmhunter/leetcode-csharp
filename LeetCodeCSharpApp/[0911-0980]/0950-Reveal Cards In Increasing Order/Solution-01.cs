namespace LeetCodeCSharpApp.RevealCardsInIncreasingOrder01;

public class Solution
{
    public int[] DeckRevealedIncreasing(int[] deck)
    {
        var n = deck.Length;
        Array.Sort(deck);
        var q = new Queue<int>();

        for (var i = n - 1; i >= 0; i--)
        {
            if (q.Count > 0)
                q.Enqueue(q.Dequeue());

            q.Enqueue(deck[i]);
        }

        var result = new int[n];

        for (var i = n - 1; i >= 0; i--)
            result[i] = q.Dequeue();

        return result;
    }
}