namespace LeetCodeCSharpApp.GasStation01;

public class Solution
{
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        var sum = gas[^1] - cost[^1];
        var maxIndex = gas.Length - 1;
        var maxSum = sum;

        for (var i = gas.Length - 2; i >= 0; i--)
        {
            sum += gas[i] - cost[i];

            if (sum <= maxSum)
                continue;

            maxIndex = i;
            maxSum = sum;
        }

        if (sum < 0)
            return -1;

        return maxIndex;
    }
}
