namespace LeetCodeCSharpApp.MaximumNumberOfRobotsWithinBudget01;

public class Solution
{
    public int MaximumRobots(int[] chargeTimes, int[] runningCosts, long budget)
    {
        long sum = 0;
        int i = 0, n = chargeTimes.Length;
        var d = new LinkedList<int>();
        
        for (var j = 0; j < n; ++j)
        {
            sum += runningCosts[j];
            
            while (d.Count != 0 && chargeTimes[d.Last!.Value] <= chargeTimes[j])
                d.RemoveLast();
            
            d.AddLast(j);

            if (chargeTimes[d.First()] + (j - i + 1) * sum <= budget)
                continue;
            
            if (d.First() == i)
                d.RemoveFirst();
                
            sum -= runningCosts[i++];
        }

        return n - i;
    }
}
