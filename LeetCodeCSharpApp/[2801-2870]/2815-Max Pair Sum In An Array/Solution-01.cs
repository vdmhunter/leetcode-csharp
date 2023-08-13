namespace LeetCodeCSharpApp.MaxPairSumInAnArray01;

public class Solution
{
    public int MaxSum(int[] nums)
    {
        var result = -1;
        var maxN = new int[10];

        foreach (var n in nums)
        {
            var maxD = 0;

            for (var i = n; i > 0; i /= 10)
                maxD = Math.Max(maxD, i % 10);

            if (maxN[maxD] > 0)
                result = Math.Max(result, maxN[maxD] + n);

            maxN[maxD] = Math.Max(maxN[maxD], n);
        }

        return result;
    }
}
