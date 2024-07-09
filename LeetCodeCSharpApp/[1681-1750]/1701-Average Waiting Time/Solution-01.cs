namespace LeetCodeCSharpApp.AverageWaitingTime01;

public class Solution
{
    public double AverageWaitingTime(int[][] customers)
    {
        var ready = 0;
        var waitTotal = 0D;

        foreach (int[] c in customers)
        {
            ready = Math.Max(ready, c[0]) + c[1];
            waitTotal += ready - c[0];
        }

        return waitTotal / customers.Length;
    }
}
