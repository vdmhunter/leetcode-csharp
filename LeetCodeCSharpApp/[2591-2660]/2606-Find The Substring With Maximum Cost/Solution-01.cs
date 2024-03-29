// ReSharper disable IdentifierTypo

namespace LeetCodeCSharpApp.FindTheSubstringWithMaximumCost01;

public class Solution
{
    public int MaximumCostSubstring(string s, string chars, int[] vals)
    {
        var maxCost = int.MinValue;
        var currentSum = 0;

        var arr = s.ToCharArray().Select(c =>
        {
            if (!chars.Contains(c))
                return c - 'a' + 1;

            var idx = chars.IndexOf(c);

            return vals[idx];
        }).ToArray();

        foreach (var n in arr)
        {
            currentSum += n;

            if (currentSum > maxCost)
                maxCost = currentSum;

            if (currentSum < 0)
                currentSum = 0;
        }

        return maxCost < 0 ? 0 : maxCost;
    }
}
