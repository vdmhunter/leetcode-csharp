namespace LeetCodeCSharpApp.SmallestMissingNonNegativeIntegerAfterOperations01;

public class Solution
{
    public int FindSmallestInteger(int[] nums, int value)
    {
        var stop = 0;
        var count = new int[value];

        foreach (var n in nums)
            count[(n % value + value) % value]++;

        for (var i = 0; i < value; i++)
            if (count[i] < count[stop])
                stop = i;

        return value * count[stop] + stop;
    }
}
