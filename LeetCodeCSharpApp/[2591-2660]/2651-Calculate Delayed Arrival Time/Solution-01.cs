namespace LeetCodeCSharpApp.CalculateDelayedArrivalTime01;

public class Solution
{
    public int FindDelayedArrivalTime(int arrivalTime, int delayedTime)
    {
        return (arrivalTime + delayedTime) % 24;
    }
}
