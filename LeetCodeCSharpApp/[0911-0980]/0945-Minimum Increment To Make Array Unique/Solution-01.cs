namespace LeetCodeCSharpApp.MinimumIncrementToMakeArrayUnique01;

public class Solution
{
    public int MinIncrementForUnique(int[] nums)
    {
        Array.Sort(nums);

        var numTracker = 0;
        var minIncrement = 0;

        foreach (int num in nums)
        {
            numTracker = Math.Max(numTracker, num);
            minIncrement += numTracker - num;
            numTracker += 1;
        }

        return minIncrement;
    }
}
