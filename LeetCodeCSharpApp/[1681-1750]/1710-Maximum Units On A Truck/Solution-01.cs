namespace LeetCodeCSharpApp.MaximumUnitsOnATruck01;

public class Solution
{
    public int MaximumUnits(int[][] boxTypes, int truckSize)
    {
        Array.Sort(boxTypes, (a, b) => b[1] - a[1]);

        var result = 0;

        foreach (var b in boxTypes)
        {
            var count = Math.Min(b[0], truckSize);
            result += count * b[1];
            truckSize -= count;

            if (truckSize == 0)
                return result;
        }

        return result;
    }
}
