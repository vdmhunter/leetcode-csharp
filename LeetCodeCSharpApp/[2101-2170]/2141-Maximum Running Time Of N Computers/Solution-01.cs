namespace LeetCodeCSharpApp.MaximumRunningTimeOfNComputers01;

public class Solution
{
    public long MaxRunTime(int n, int[] batteries)
    {
        Array.Sort(batteries);
        var sum = batteries.Aggregate(0L, (current, i) => current + i);

        int k = 0, na = batteries.Length;

        while (batteries[na - 1 - k] > sum / (n - k))
            sum -= batteries[na - 1 - k++];
            
        return sum / (n - k);
    }
}
