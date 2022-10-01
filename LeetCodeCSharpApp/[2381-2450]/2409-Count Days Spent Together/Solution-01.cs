namespace LeetCodeCSharpApp.CountDaysSpentTogether01;

public class Solution
{
    private readonly int[] _days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    public int CountDaysTogether(string arriveAlice, string leaveAlice, string arriveBob, string leaveBob)
    {
        var aliceS = GetDay(arriveAlice);
        var aliceE = GetDay(leaveAlice);
        var bobS = GetDay(arriveBob);
        var bobE = GetDay(leaveBob);

        if (aliceS > bobS)
        {
            (_, bobS) = (bobS, aliceS);
            (aliceE, bobE) = (bobE, aliceE);
        }

        var together = Math.Max(0, Math.Min(aliceE, bobE) - bobS + 1);
        return together;
    }

    private int GetDay(string date)
    {
        var parts = date.Split("-");
        var month = int.Parse(parts[0]) - 1;
        var day = int.Parse(parts[1]);
        var days = 0;

        while (month-- > 0)
            days += _days[month];

        days += day;

        return days;
    }
}
