namespace LeetCodeCSharpApp.MinimumNumberOfMovesToSeatEveryone01;

public class Solution
{
    public int MinMovesToSeat(int[] seats, int[] students)
    {
        Array.Sort(seats);
        Array.Sort(students);

        return seats.Select((t, i) => Math.Abs(t - students[i])).Sum();
    }
}
