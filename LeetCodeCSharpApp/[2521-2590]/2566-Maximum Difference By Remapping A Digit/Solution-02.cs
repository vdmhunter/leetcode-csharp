namespace LeetCodeCSharpApp.MaximumDifferenceByRemappingADigit02;

public class Solution
{
    public int MinMaxDifference(int num)
    {
        int minV = num, maxV = num;

        for (var i = 0; i < 10; ++i)
        {
            int lo = 0, hi = 0, mul = 1;

            for (var n = num; n != 0; n /= 10)
            {
                var replace = n % 10 == i;
                lo += (replace ? 0 : n % 10) * mul;
                hi += (replace ? 9 : n % 10) * mul;
                mul *= 10;
            }

            minV = Math.Min(minV, lo);
            maxV = Math.Max(maxV, hi);
        }

        return maxV - minV;
    }
}
