namespace LeetCodeCSharpApp.TimeNeededToBuyTickets01;

public class Solution
{
    public int TimeRequiredToBuy(int[] tickets, int k)
    {
        return tickets.Select((t, i) => Math.Min(t, i > k ? tickets[k] - 1 : tickets[k])).Sum();
    }
}
